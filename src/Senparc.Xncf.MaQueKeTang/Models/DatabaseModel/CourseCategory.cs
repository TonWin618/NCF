//------------------------------------------------------------------------------
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:feng yuan
//------------------------------------------------------------------------------
using Senparc.Ncf.Core.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Senparc.Xncf.MaQueKeTang.Request;

namespace Senparc.Xncf.MaQueKeTang
{
    /// <summary>
    ///实体类
    /// </summary>

    [Table(Register.DATABASE_PREFIX + nameof(CourseCategory))]//必须添加前缀，防止全系统中发生冲突
    [Serializable]
    public class CourseCategory : EntityBase<int>
    {
        public CourseCategory()
        {
            this.name = "";
            this.parent_id = 0;
            this.parent_name = "";
            this.is_show = 0;
            this.sort = 0;
            this.Flag = false;
            this.AddTime = DateTime.Now; ;
            this.LastUpdateTime = DateTime.Now; ;
            this.AdminRemark = "";
            this.Remark = "";
            this.TenantId = 0;
            this.deleted_at = DateTime.Now; ;

        }
        public CourseCategory(AddOrUpdateCourseCategoryReq req)
        {
            this.name = req.name;
            this.parent_id = req.parent_id;
            this.parent_name = req.parent_name;
            this.is_show = req.is_show;
            this.sort = req.sort;
            this.AdminRemark = req.AdminRemark;
            this.Remark = req.Remark;

        }

        /// <summary>
        ///分类名
        /// </summary>
        [Description("分类名")]
        public string name { get; set; }

        /// <summary>
        ///父id
        /// </summary>
        [Description("父id")]
        public int parent_id { get; set; }

        /// <summary>
        ///父级名称
        /// </summary>
        [Description("父级名称")]
        public string parent_name { get; set; }

        /// <summary>
        ///是否显示,1显示,0不显示
        /// </summary>
        [Description("是否显示,1显示,0不显示")]
        public byte is_show { get; set; }

        /// <summary>
        ///升序
        /// </summary>
        [Description("升序")]
        public int sort { get; set; }

        /// <summary>
        ///删除状态
        /// </summary>
        [Description("删除状态")]
        public bool Flag { get; set; }

        /// <summary>
        ///添加时间
        /// </summary>
        [Description("添加时间")]
        public DateTime AddTime { get; set; }

        /// <summary>
        ///最后修改时间
        /// </summary>
        [Description("最后修改时间")]
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        ///备注
        /// </summary>
        [Description("备注")]
        public string AdminRemark { get; set; }

        /// <summary>
        ///说明
        /// </summary>
        [Description("说明")]
        public string Remark { get; set; }

        /// <summary>
        ///租户Id
        /// </summary>
        [Description("租户Id")]
        public int TenantId { get; set; }

        /// <summary>
        ///删除时间
        /// </summary>
        [Description("删除时间")]
        public DateTime? deleted_at { get; set; }


    }
}
