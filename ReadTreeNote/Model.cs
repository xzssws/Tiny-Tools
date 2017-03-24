using System.Collections.Generic;

namespace ReadTreeNote
{
    /// <summary>
    /// 表示目录层次
    /// </summary>
    public class Model
    {
        public Model()
        {
        }

        public Model(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 节点的子节点集合
        /// </summary>
        public List<Model> _Ls { get; set; }

        /// <summary>
        /// 当前节点
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 父节点序号
        /// </summary>
        public int ParentID { get; set; }

        /// <summary>
        /// 排序序号
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 子项当前序号
        /// </summary>
        public int OZid { get; set; }

        /// <summary>
        /// 关联的URL路径
        /// </summary>
        public string URL { get; set; }
    }
}