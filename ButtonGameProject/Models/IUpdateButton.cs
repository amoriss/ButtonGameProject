using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButtonGameProject.Models
{
    public interface IUpdateButton
    {
        public void GenerateBadButton();
        public void Choice(int guess);
        public void ScoreIncrease();
        public void ScoreReset();
    }

}
