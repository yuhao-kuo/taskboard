using System;
using System.Collections.Generic;

namespace taskboard.Models
{
    /// <summary>
    /// 控制面板
    /// </summary>
    public class TaskControlBoard
    {
        public int ControlBoardID { get; set; }
        public string BoardName { get; set; }
        public List<CardList> CardLists { get; set; } = new();
    }

    /// <summary>
    /// 卡片清單
    /// </summary>
    public class CardList
    {
        public int CardListID { get; set; }
        public int ControlBoardID { get; set; }
        public string ListName { get; set; }
        public List<TaskCard> Cards { get; set; } = new();
    }

    /// <summary>
    /// 任務卡片
    /// </summary>
    public class TaskCard
    {
        public int CardListID { get; set; }
        public int TaskID { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public List<TaskItem> Items { get; set; } = new();
        public List<TaskTag> Tags { get; set; } = new();
        public List<TaskAppendixFile> Files { get; set; } = new();
    }

    /// <summary>
    /// 待辦清單
    /// </summary>
    public class TaskItem
    {
        public int ItemID { get; set; }
        public int TaskID { get; set; }
        public bool Checked { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// 標籤
    /// </summary>
    public class TaskTag
    {
        public int TagID { get; set; }
        public int TaskID { get; set; }
        public string Infomation { get; set; }
    }

    /// <summary>
    /// 附件檔案
    /// </summary>
    public class TaskAppendixFile
    {
        public int AppendixFileID { get; set; }
        public int TaskID { get; set; }
        public string FilePath { get; set; }
    }
}