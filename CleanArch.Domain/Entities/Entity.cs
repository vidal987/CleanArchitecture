﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    //ABSTRACT PQ NÃO PODE SER INSTANCIADA
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
