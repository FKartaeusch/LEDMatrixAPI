using Engine.Models;
using Engine.Models.DTO;

namespace Engine.Core
{
    public interface IStateHandler
    {
        public State GetCurrentState();

        public void SetState(StateDTO stateDTO);

        public void ChangeState(StateDTO dto);
    }
}