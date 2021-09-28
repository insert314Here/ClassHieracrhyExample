using ClassHieracrhyExample.Adventures;

namespace ClassHieracrhyExample.Game.Interfaces
{
    public interface IGameService
    {
        bool StartGame(Adventure adventure = null);
    }
}