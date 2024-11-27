using System;
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
    /// <summary>
    /// Класс основной программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объемов фигур.
        /// </summary>
        private BindingList<FigureBase> _figureList = new BindingList<FigureBase>();

        /// <summary>
        /// Список отфильтрованных объемов фигур.
        /// </summary>
        private BindingList<FigureBase> _filterFigureList = new BindingList<FigureBase>();

        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<FigureBase>));

        /// <summary>
        /// Поле для хранения состояния фильтрации.
        /// </summary>
        private bool _filter = false;

        /// <summary>
		/// Поле для хранения состояния формы добавления.
		/// </summary>
		private bool _addFormOpen = false;

        /// <summary>
        /// Поле для хранения состояния формы фильтра.
        /// </summary>
        private bool _filterFormOpen = false;

        /// <summary>
        /// Конструктор MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Создание таблицы.
        /// </summary>
        /// <param name="figure">Список фигур.</param>
        /// <param name="dataGridView">Сетка.</param>
        public static void CreateTable(BindingList<FigureBase> figure,
              DataGridView dataGridViewSpace)
        {
            dataGridViewSpace.RowHeadersVisible = false;
            var source = new BindingSource(figure, null);
            dataGridViewSpace.DataSource = source;

            dataGridViewSpace.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSpace.AllowUserToResizeColumns = false;
            dataGridViewSpace.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSpace.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSpace.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSpace.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dataGridViewSpace.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void LoadMainForm(object sender, EventArgs e)
        {
            _figureList = new BindingList<FigureBase>();
            CreateTable(_figureList, _dataGridViewSpace);
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void AddButton(object sender, EventArgs e)
        {
            AddForm addFigure = new AddForm();
            addFigure.FigureAdded += AddFigure;
            ActiveButtons();
            addFigure.FormClosed += (s, args) =>
            {
                _addFormOpen = false;
                ActiveButtons();
            };
            addFigure.Show();
        }

        /// <summary>
        /// Добавление данных в лист.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="figureBase">Объект класса FigureBase.</param>
        private void AddFigure(object sender, EventArgs figureBase)
        {
            AddVolume addEventArgs =
                figureBase as AddVolume;
            _figureList.Add(addEventArgs?.FigureBase);
        }

        /// <summary>
        /// Метод нажатия на кнопку "Удалить".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void DeleteButton(object sender, EventArgs e)
        {
            if (_dataGridViewSpace.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    _dataGridViewSpace.SelectedRows)
                {
                    if (row.DataBoundItem is FigureBase figure)
                    {
                        _figureList.Remove(figure);
                        if (_filterFigureList != null
                            && _filterFigureList.Count > 0)
                        {
                            _filterFigureList.Remove(figure);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Фильтр".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void FilterButton(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm(_figureList);
            filter.FilterFigure += Filtered;
            _filterFormOpen = true;
            ActiveButtons();
            filter.FormClosed += (s, args) =>
            {
                _filterFormOpen = false;
                ActiveButtons();
            };
            filter.Show();
        }

        /// <summary>
		/// Обработчик фильтрации данных.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="figureList">Список фифгур в таблице.</param>
		private void Filtered(object sender, EventArgs figureList)
        {
            FilterFigure filterEventArgs =
                 figureList as FilterFigure;
            _filterFigureList = filterEventArgs?.FilterFigureList;
            _filter = true;
            ActiveButtons();
            CreateTable(_filterFigureList, _dataGridViewSpace);
        }

        /// <summary>
        /// Метод нажатия на кнопку "Очистить".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClearButton(object sender, EventArgs e)
        {
            _dataGridViewSpace.ClearSelection();
            foreach (DataGridViewRow row in _dataGridViewSpace.Rows)
            {
                row.Selected = true;
            }

            _dataGridViewSpace.ClearSelection();
            foreach (DataGridViewRow row in _dataGridViewSpace.Rows)
            {
                row.Selected = true;
            }
            foreach (DataGridViewRow row in
                    _dataGridViewSpace.SelectedRows)
            {
                if (row.DataBoundItem is FigureBase figure)
                {
                    _figureList.Remove(figure);
                    if (_filterFigureList != null
                        && _filterFigureList.Count > 0)
                    {
                        _filterFigureList.Remove(figure);
                    }
                }
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Рандомайзер".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void RandomButton(object sender, EventArgs e)
        {
            _figureList.Add(RandomFigure.GetRandomFigure());
        }

        /// <summary>
        /// Метод нажатия на кнопку "Сброс фильтра".
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ResetFilterButton(object sender, EventArgs e)
        {
            CreateTable(_figureList, _dataGridViewSpace);
            _filter = false;
            ActiveButtons();
        }

        /// <summary>
		/// Метод обновления состояний кнопок.
		/// </summary>
		private void ActiveButtons()
        {
            _addButton.Enabled = !_filterFormOpen &&
                !_filter && !_addFormOpen;

            _filterButton.Enabled = !_addFormOpen &&
                !_filterFormOpen;

            _toolStripDropDownButton.Enabled = !_filter;

            _randomButton.Enabled = !_filterFormOpen &&
                _toolStripDropDownButton.Enabled;
        }

        /// <summary>
        /// Сохранение результатов в файл.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void SaveToolStripMenuItem(object sender, EventArgs e)
        {
            if (!_figureList.Any() || _figureList is null)
            {
                MessageBox.Show("Список пуст!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.figvol)|*.figvol|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName.ToString();

                using (var file = File.Create(filePath))
                {
                    _serializer.Serialize(file, _figureList);
                }
                MessageBox.Show("Файл сохранён.", "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Загрузка файла.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void OpenToolStripMenuItem(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.figvol)|*.figvol|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(filePath))
                {
                    _figureList = (BindingList<FigureBase>)
                        _serializer.Deserialize(file);
                }

                _dataGridViewSpace.DataSource = _figureList;
            }
            catch (Exception)
            {
                MessageBox.Show("Файл поврежден!",
                    "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

