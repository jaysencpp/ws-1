using Fagdag.Domain.Enums;

namespace Fagdag.Domain.Policies;

public interface IStateChangePolicy
{
    public void ChangeState(State newState);
}