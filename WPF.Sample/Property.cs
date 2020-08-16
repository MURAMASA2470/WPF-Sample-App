using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using static WPF.Sample.MainWindow;

namespace WPF.Sample
{
    public class Property : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Network> m_gridList = new ObservableCollection<Network>();
        public ObservableCollection<Network> GridList
        {
            get { return m_gridList; }
            set { this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(m_gridList))); }
        }
    }
}