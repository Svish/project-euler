using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Iterates over all the <see cref="IProblem"/>s found in this assembly.
    /// </summary>
    public class ProblemIterator : IEnumerable<IProblem>
    {
        public IEnumerator<IProblem> GetEnumerator()
        {
            var problems = Assembly
                .GetAssembly(typeof(IProblem))
                .GetTypes()
                .Where(x => x.IsClass
                         && !x.IsAbstract
                         && typeof(IProblem).IsAssignableFrom(x))
                .OrderBy(x => x.Name, new NaturalStringComparer());

            foreach(var p in problems)
                yield return (IProblem)Activator.CreateInstance(p);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
