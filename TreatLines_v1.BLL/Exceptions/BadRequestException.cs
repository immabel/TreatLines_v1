using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace TreatLines_v1.BLL.Exceptions
{
    public class BadRequestException : CustomHttpException
    {
        public BadRequestException(string message)
            : base(message, HttpStatusCode.BadRequest)
        {
        }
    }
}
