using System;

namespace WinFormsApp1.Utils
{
    public abstract class OperationResult<TValue>
    {
        public abstract bool IsSuccess { get; }
        public abstract TValue Value { get; }
    }
    
    public sealed class Success<TValue> : OperationResult<TValue>
    {
        public override bool IsSuccess => true;
        public override TValue Value { get; }

        public Success(TValue value)
        {
            Value = value;
        }
    }

    public sealed class Failed<TValue> : OperationResult<TValue>
    {
        public override bool IsSuccess => false;
        public override TValue Value => default;
        public Exception Cause { get; }

        public Failed(Exception cause)
        {
            Cause = cause;
        }
    }
}