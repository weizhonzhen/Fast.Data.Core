﻿namespace FastUntility.Core.Page
{
    /// <summary>
    /// 分页model
    /// </summary>
    public class PageModel
    {
        /// <summary>
        /// 起始Id
        /// </summary>
        public int StarId { get; set; }

        /// <summary>
        /// 结束Id
        /// </summary>
        public int EndId { get; set; }

        /// <summary>
        /// 共多少条
        /// </summary>
        public int TotalRecord { get; set; }

        /// <summary>
        /// 共几页
        /// </summary>
        public int TotalPage { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        public int PageId { get; set; } = 1;

        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize { get; set; } = 10;
    }
}
