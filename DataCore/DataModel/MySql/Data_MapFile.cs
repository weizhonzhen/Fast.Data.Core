﻿using Data.Core.Property;
using System;

namespace Data.Core.DataModel.MySql
{

    /// <summary>
    /// mysql map文件表
    /// </summary>
    [Table(Comments = "map文件")]
    internal class Data_MapFile
    {
        /// <summary>
        /// map id
        /// </summary>
        [Column(Comments = "Map id", DataType = "Char", Length = 32, IsNull = false, IsKey = true)]
        public string MapId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [Column(Comments = "文件名称", DataType = "Char", IsNull = true, Length = 32)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [Column(Comments = "文件路径", DataType = "Char", IsNull = true, Length = 255)]
        public string FilePath { get; set; }

        /// <summary>
        /// 明文文件内容
        /// </summary>
        [Column(Comments = "明文文件内容", DataType = "Text", IsNull = true)]
        public string DeFileContent { get; set; }

        /// <summary>
        /// 加密文件内容
        /// </summary>
        [Column(Comments = "加密文件内容", DataType = "Text", IsNull = true)]
        public string EnFileContent { get; set; }


        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Column(Comments = "最后修改时间", DataType = "Date", IsNull = true)]
        public DateTime LastTime { get; set; }
    }
}
