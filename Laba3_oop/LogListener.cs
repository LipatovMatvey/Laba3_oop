using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    internal class LogListener
    {
        /// <summary>
        /// Ссылка на текстовое поле для вывода лога
        /// </summary>
        private System.Windows.Forms.ListView _listView;

        /// <summary>
        /// Внутреннее хранилище всех сообщений
        /// </summary>
        private List<string> _messages = new List<string>();

        /// <summary>
        /// Максимальное количество сообщений
        /// </summary>
        private const int MaxMessages = 5_000;

        /// <summary>
        /// Счётчик накопленных изменений для пакетного обновления UI
        /// </summary>
        private int _pendingUpdates = 0;

        /// <summary>
        /// Размер "пакета" — сколько сообщений добавляем перед обновлением ListView
        /// </summary>
        private const int UpdateBatchSize = 100;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="logListView">Текстовое поле для вывода лога</param>
        public LogListener(System.Windows.Forms.ListView listView)
        {
            _listView = listView;
            _listView.RetrieveVirtualItem += OnRetrieveVirtualItem;
        }

        /// <summary>
        /// Вызывается ListView, когда нужно отобразить элемент с определённым индексом 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < _messages.Count)
            {
                e.Item = new ListViewItem(_messages[e.ItemIndex]);
            }
        }

        /// <summary>
        /// Обработчик событий изменения коллекции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCollectionChanged(object sender, CollectionEventArgs e)
        {
            string itemText = e.Item?.ToString() ?? "null";
            string message = $"{DateTime.Now:T} — {e.Action}: ключ '{e.Key}', объект: {itemText}";
            AddMessageThreadSafe(message);
        }

        /// <summary>
        /// Обеспечивает выполнение в UI-потоке
        /// </summary>
        /// <param name="message"></param>
        private void AddMessageThreadSafe(string message)
        {
            if (_listView.InvokeRequired)
            {
                _listView.BeginInvoke(new Action<string>(AddMessageThreadSafe), message);
                return;
            }
            AddMessage(message);
        }


        /// <summary>
        /// Метод для добавления сообщения в текстовое поле
        /// </summary>        
        /// <param name="message">Текст сообщения для добавления</param>
        private void AddMessage(string message)
        {
            _messages.Add(message);
            //if (_messages.Count > MaxMessages)
            //{
            //    _messages.RemoveRange(0, _messages.Count - MaxMessages);
            //}
            _pendingUpdates++;
            if (_pendingUpdates >= UpdateBatchSize)
            {
                _pendingUpdates = 0;
                _listView.VirtualListSize = _messages.Count;
                if (_messages.Count > 0)
                {
                    _listView.EnsureVisible(_messages.Count - 1);
                }
            }
        }
    }
}
