using IsoDoc.Domain.Entities;
using IsoDoc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDoc.Domain.Interfaces.Repositories
{
    public interface IDocRequestStepsRepository
    {
        Task<DocRequestStep> SetDocRequestStepApproved(int docReqStepId);

    }

}
