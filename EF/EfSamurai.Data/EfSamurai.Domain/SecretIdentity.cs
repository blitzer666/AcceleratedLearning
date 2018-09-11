﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Domain
{
    // Dependent (child) entitet till Samurai

    public class SecretIdentity
    {
        public int Id { get; set; }
        public string RealName { get; set; }

        public int SamuraiId { get; set; } // har denna foreign-key property + kommer göras unik eftersom det är en ett-till-ett-relation
        public Samurai Samurai { get; set; }
    }
}
