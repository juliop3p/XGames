﻿using System;

namespace XGames.Domain.Entities
{
    public class MeusJogo
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }
        public DateTime DataDesejo { get; set; }

    }
}
