﻿using Dorisoy.Pan.Common.GenericRespository;
using Dorisoy.Pan.Common.UnitOfWork;
using Dorisoy.Pan.Data;
using Dorisoy.Pan.Domain;

namespace Dorisoy.Pan.Repository
{
        public class DocumentUserPermissionRepository : GenericRepository<DocumentUserPermission, DocumentContext>,
              IDocumentUserPermissionRepository
    {
        public DocumentUserPermissionRepository(
            IUnitOfWork<DocumentContext> uow
            ) : base(uow)
        {
        }
    }
}
