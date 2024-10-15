using Izzet.Core.Concrate;
using Izzet.DataAccess.Abstract;
using Izzet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izzet.DataAccess.Concrate
{
    internal class Todo : BaseRepository<TodoModel,MyDbContext>, IToDo
    {
    }
}
