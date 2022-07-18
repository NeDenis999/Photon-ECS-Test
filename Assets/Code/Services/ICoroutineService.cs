using System.Collections;
using System.Collections.Generic;

namespace Code
{
    public interface ICoroutineService
    {
        void StartCoroutine(IEnumerator enumerator);
    }
}