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

    [Table(Register.DATABASE_PREFIX + nameof(CourseAttach))]//必须添加前缀，防止全系统中发生冲突
    [Serializable]
    public class CourseAttach : EntityBase<int>
    {
    public CourseAttach()
    {
           this.CourseId=0;
       this.name="";
       this.path="";
       this.disk="";
       this.size=0;
       this.extension="";
       this.only_buyer=0;
       this.download_times=0;
       this.Flag=false;
       this.AddTime=DateTime.Now;;
       this.LastUpdateTime=DateTime.Now;;
       this.AdminRemark="";
       this.Remark="";
       this.TenantId=0;
       this.deleted_at=DateTime.Now;;

    }
    public CourseAttach(AddOrUpdateCourseAttachReq req)
    {
           this.CourseId= req.CourseId;
       this.name= req.name;
       this.path= req.path;
       this.disk= req.disk;
       this.size= req.size;
       this.extension= req.extension;
       this.only_buyer= req.only_buyer;
       this.download_times= req.download_times;
       this.Flag= req.Flag;
       this.AddTime= req.AddTime;
       this.LastUpdateTime= req.LastUpdateTime;
       this.AdminRemark= req.AdminRemark;
       this.Remark= req.Remark;
       this.TenantId= req.TenantId;
       this.deleted_at= req.deleted_at;

    }

    /// <summary>
       ///课程Id
       /// </summary>
       [Description("课程Id")]
       public int CourseId { get; set; }

       /// <summary>
       ///附件名
       /// </summary>
       [Description("附件名")]
       public string name { get; set; }

       /// <summary>
       ///路径
       /// </summary>
       [Description("路径")]
       public string path { get; set; }

       /// <summary>
       ///存储磁盘
       /// </summary>
       [Description("存储磁盘")]
       public string disk { get; set; }

       /// <summary>
       ///单位：byte
       /// </summary>
       [Description("单位：byte")]
       public int size { get; set; }

       /// <summary>
       ///文件格式
       /// </summary>
       [Description("文件格式")]
       public string extension { get; set; }

       /// <summary>
       ///只有购买者可以下载,1是,0否
       /// </summary>
       [Description("只有购买者可以下载,1是,0否")]
       public byte only_buyer { get; set; }

       /// <summary>
       ///下载次数
       /// </summary>
       [Description("下载次数")]
       public int download_times { get; set; }

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
