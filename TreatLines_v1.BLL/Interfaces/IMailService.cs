﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TreatLines_v1.BLL.Interfaces
{
    public interface IMailService
    {
        Task SendAsync(string receiver, string subject, string bodyHtml);
    }
}
