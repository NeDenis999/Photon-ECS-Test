using System.Collections;
using UnityEngine;

namespace Code.Services
{
    public class UnityCoroutineService : ICoroutineService
    {
        private MonoBehaviour _monoBehaviour;

        public UnityCoroutineService(MonoBehaviour monoBehaviour)
        {
            _monoBehaviour = monoBehaviour;
        }
        
        public void StartCoroutine(IEnumerator enumerator)
        {
            _monoBehaviour.StartCoroutine(enumerator);
        }
    }
}