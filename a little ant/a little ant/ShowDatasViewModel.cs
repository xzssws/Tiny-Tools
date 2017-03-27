using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace a_little_ant
{
    /// <summary>
    /// [数据展示窗口] 业务逻辑类
    /// </summary>
    public class ShowDatasViewModel : INotifyPropertyChanged
    {
        public ShowDatasView view { get; set; }
        /// <summary>
        /// 根数据描述 属性字段
        /// <para>关联属性: RootDatas</para>
        /// </summary>
        private System.Collections.ObjectModel.ObservableCollection<model.NoteInfo> _rootDatas;
        /// <summary>
        /// 根数据描述
        /// </summary>
        public System.Collections.ObjectModel.ObservableCollection<model.NoteInfo> RootDatas
        {
            get
            {
                if (_rootDatas == null) _rootDatas = new System.Collections.ObjectModel.ObservableCollection<model.NoteInfo>();
                return _rootDatas;
            }
            set
            {
                _rootDatas = value;
                if (PropertyChanged != null) PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("RootDatas"));
            }
        }

        /// <summary>
        /// 当前选择记录 属性字段
        /// <para>关联属性: CurrentData</para>
        /// </summary>
        private model.NoteInfo _currentData;
        /// <summary>
        /// 当前选择记录
        /// </summary>
        public model.NoteInfo CurrentData
        {
            get { return _currentData; }
            set
            {
                _currentData = value;
                view.webb.NavigateToString(_currentData.FullText);
                if (PropertyChanged != null) PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("CurrentData"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
