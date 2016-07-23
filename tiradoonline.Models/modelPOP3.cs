using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;

namespace tiradoonline.Models
{
    public class modelPOP3EmailAccount
    {
        public int POP3EmailAccountId { get; set; }
        public int UserID { get; set; }
        public string POP3EmailAccountName { get; set; }
        public string POP3EmailAccountServer { get; set; }
        public string POP3EmailAccountEmail { get; set; }
        public string POP3EmailAccountUserName { get; set; }
        public string POP3EmailAccountPassword { get; set; }
        public bool POP3EmailAccountSSL { get; set; }
        public bool Active { get; set; }
        public DateTime create_dt { get; set; }
        public List<modelPOP3EmailAccount> listPOP3EmailAccount { get; set; }
    }

    public class modelPOP3Folder
    {
        public int POP3EmailFolderId { get; set; }
        public int POP3EmailAccountId { get; set; }
        public string POP3EmailFolderName { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool Active { get; set; }
        public DateTime create_dt { get; set; }
        public List<modelPOP3Folder> listPOP3Folder { get; set; }
    }

    public class modelPOP3Email
    {
        public int POP3EmailId { get; set; }
        public int POP3FolderId { get; set; }
        public string POP3EmailMessageId { get; set; }
        public string POP3EmailMessageDateTime { get; set; }
        public DateTime POP3EmailMessageDateSent { get; set; }
        public string POP3EmailFromName { get; set; }
        public string POP3EmailFromEmail { get; set; }
        public string POP3EmailSubject { get; set; }
        public string POP3EmailBodyText { get; set; }
        public bool Active { get; set; }
        public DateTime create_dt { get; set; }
        public List<modelPOP3Email> listPOP3Email { get; set; }
    }

    public class modelPOP3EmailRule
    {
        public int POP3EmailRuleId { get; set; }
        public int POP3EmailAccountId { get; set; }
        public string POP3EmailFolderId { get; set; }
        public string POP3EmailRuleEmailAddress { get; set; }
        public bool Active { get; set; }
        public DateTime create_dt { get; set; }
        public List<modelPOP3EmailRule> listPOP3EmailRule { get; set; }
    }

}
