using IfeedsApi.Config.Database;
using IfeedsApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Domain.Services
{
    public class FeedbackService
    {
        private readonly ApplicationDbContext _context;

        public FeedbackService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Feedback> Listar()
        {

            return _context.Feedbacks.ToList();
        }
    }
}
