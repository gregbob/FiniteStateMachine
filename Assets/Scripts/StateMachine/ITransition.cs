using UnityEngine;
using System.Collections;

namespace GB.StateMachine {
    public class ITransition <T>
    {
        /// <summary>
        /// Start state identifier.
        /// </summary>
        private T start;

        /// <summary>
        /// End state identifier.
        /// </summary>
        private T end;

        public T Start { get { return start; } }
        public T End { get { return end; } }

        public ITransition (T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        
        public override bool Equals(object obj)
        {
            ITransition<T> transition = (ITransition<T>)obj;

            return start.Equals(transition.start) && end.Equals(transition.end);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + start.GetHashCode();
            hash = hash * 23 + end.GetHashCode();

            return hash;
        }
    }
}


