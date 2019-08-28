using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIP.System.Models.Entities
{
    /// <summary>
    /// �������ű��ʵ����
    /// </summary>
    [Serializable]
    [Table("System_Article")]
    public class SystemArticle 
    {
        /// <summary>
        /// ����
        /// </summary>
        [Key]
        public Guid ArticleId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// ��Ŀ
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// ��Ŀ
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// �Ƿ񶳽�
        /// </summary>
        public bool IsFreeze { get; set; }

        /// <summary>
        /// �Ƿ�����ҳ��ʾ
        /// </summary>
        public bool ShowInHome { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public int ViewNums { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public int OrderNo { get; set; }=0;

        /// <summary>
        /// �����������
        /// </summary>
        public Guid CreateOrganizationId { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        public string CreateOrganizationName { get; set; }

        /// <summary>
        /// �����û����
        /// </summary>
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// �����û�����
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// �޸Ļ������
        /// </summary>
        public Guid UpdateOrganizationId { get; set; }

        /// <summary>
        /// �޸Ļ�������
        /// </summary>
        public string UpdateOrganizationName { get; set; }

        /// <summary>
        /// �޸��û����
        /// </summary>
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// �޸��û�����
        /// </summary>
        public string UpdateUserName { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime? UpdateTime { get; set; }


    }
}