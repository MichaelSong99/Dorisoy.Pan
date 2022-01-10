﻿using Dorisoy.Pan.Helper;
using MediatR;
using System;

namespace Dorisoy.Pan.MediatR.Commands
{
    public class DeleteDocumentShareableLinkCommand : IRequest<ServiceResponse<bool>>
    {
        public Guid Id { get; set; }
    }
}
