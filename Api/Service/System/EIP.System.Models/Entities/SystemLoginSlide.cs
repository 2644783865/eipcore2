using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIP.System.Models.Entities
{
    /// <summary>
    /// ��¼�õ�Ƭ��ʵ����
    /// </summary>
    [Serializable]
    [Table( "System_LoginSlide")]
    public class SystemLoginSlide 
    {
        /// <summary>
        /// ����
        /// </summary>
        [Key]
        public Guid LoginSlideId { get; set; }

        /// <summary>
        /// ͼƬ��ַ
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        /// ͼƬ����
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public bool IsFreeze { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public int OrderNo { get; set; }=0;

        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }


    }
}