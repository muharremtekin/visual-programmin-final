﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Entities.Concrete;

namespace FinalProject.DataAccess.Abstract
{
    public interface ILessonDal : IEntityRepository<Lesson>
    {
    }
}
