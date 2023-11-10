using Bytz.Collections.Dispatch.Contracts;

namespace Tests.Bytz.Collections.Dispatch.Tests.Basis;

public abstract class FunctionTestBase<TRule>
where TRule : IFunctionDispatch
{
    protected abstract TRule Rule { get; }
}