﻿using System.Collections.Generic;

namespace Users_and_Awards.Entities
{
    public interface IAwardRepository
    {
        bool AddAward(Award award);

        Award GetAward(string title);

        ICollection<Award> GetAllAwards();

        bool RemoveAward(string title);
    }
}
