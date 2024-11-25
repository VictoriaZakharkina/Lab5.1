﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Library;

namespace View
{
    //TODO+: XML
    /// <summary>
    /// Класс программы для расчета объема фигур.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объемов фигур.
        /// </summary>
        private BindingList<FigureBase> _volumeFigureList = new BindingList<FigureBase>();

        /// <summary>
        /// Список отфильтрованных объемов фигур.
        /// </summary>
        private BindingList<FigureBase> _filterVolumeFigureList = new BindingList<FigureBase>();

        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<FigureBase>));

        /// <summary>
        /// Поле для хранения состояния фильтрации.
        /// </summary>
        private bool _isFilter = false;

        /// <summary>
        /// Конструктор MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            BackColor = Color.Honeydew;
            dataGridView.BackgroundColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="figure">Список фигур.</param>
        /// <param name="dataGridView">Сетка.</param>
        public static void CreateTable(BindingList<FigureBase> figure,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(figure, null);
            dataGridView.DataSource = source;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void LoadMainForm(object sender, EventArgs e)
        {
            _volumeFigureList = new BindingList<FigureBase>();
            CreateTable(_volumeFigureList, dataGridView);
        }

        /// <summary>
        /// Метод для работы кнопки Добавить фигуру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddClick(object sender, EventArgs e)
        {
            AddForm addFigure = new AddForm();
            addFigure.FigureAdded += AddedFigure;
            addFigure.Show();
        }

        /// <summary>
        /// Метод добавления данных в лист.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="salaryBase">Объект класса FigureBase.</param>
        private void AddedFigure(object sender, EventArgs salaryBase)
        {
            VolumeAddedEvent addedEventArgs =
                salaryBase as VolumeAddedEvent;
            _volumeFigureList.Add(addedEventArgs?.FigureBase);
        }

        /// <summary>
        /// Метод для работы кнопки Удалить фигуру.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    dataGridView.SelectedRows)
                {
                    if (row.DataBoundItem is FigureBase figure)
                    {
                        _volumeFigureList.Remove(figure);
                    }
                }
            }
        }

        /// <summary>
        /// Метод для работы кнопки Фильтр.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ButtonFilterClick(object sender, EventArgs e)
        {
            FilterForm filterFigure = new FilterForm(_volumeFigureList);
            filterFigure.FigureFiltered += FilteredFigure;
            filterFigure.Show();
        }

        /// <summary>
        /// Обработчик фильтрации данных.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="figureList">Список фифгур в таблице.</param>
        private void FilteredFigure(object sender, EventArgs figureList)
        {
            FigureFilteredEvent filterEventArgs =
                 figureList as FigureFilteredEvent;
            _filterVolumeFigureList = filterEventArgs?.FilteredValueList;
            CreateTable(_filterVolumeFigureList, dataGridView);
        }

        /// <summary>
        /// Метод для работы кнопки Очистить список.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ButtonDeleteListClick(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = true;
            }
        }

        /// <summary>
        /// Добавление расчета по случайной фигуре.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ButtonRandomListClick(object sender, EventArgs e)
        {
            _volumeFigureList.Add(RandomFigure.GetRandomFigure());
        }

        /// <summary>
        /// Метод для сброса наcтроек фильтра.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ButtonResertFilterClick(object sender, EventArgs e)
        {
            CreateTable(_volumeFigureList, dataGridView);
            _isFilter = false;
        }

        /// <summary>
        /// Метод для сохранения результатов в сторонний файл.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void SaveToolStripMenuItem1(object sender, EventArgs e)
        {
            if (_volumeFigureList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.vf)|*.vf|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _volumeFigureList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Метод для загрузки файла в рабочую область.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void OpenToolStripMenuItem2(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.vf)|*.vf|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _volumeFigureList = (BindingList<FigureBase>)
                    _serializer.Deserialize(file);
                }

                dataGridView.DataSource = _volumeFigureList;
                dataGridView.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    $"Ошибка:  {ex.Message}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}

