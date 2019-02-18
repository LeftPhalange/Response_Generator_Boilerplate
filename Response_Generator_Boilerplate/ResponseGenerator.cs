using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response_Generator_Boilerplate
{
    public class ResponseGenerator
    {
        private static StringCollection _responses; // responses as a string collection, by default this is taken from the settings with Application scope
        private bool[] _isResponseUsed; // accompanying boolean array to indicate whether a response of the same index is taken or not
        private Random _rnd = new Random(); // obligatory object implemented to get a randomized index

        public ResponseGenerator (StringCollection Responses) // constructor to get the string collection, by default I have set it as a string collection, you can set it to a primitive string array and vice versa, they're all indexed the same way (e.g. _responses[index])
        {
            _responses = Responses; 
            _isResponseUsed = new bool[_responses.Count];
        }

        public ResponseGenerator(string[] Responses)
        {
            _responses = new StringCollection();
            _responses.AddRange(Responses);
            _isResponseUsed = new bool[_responses.Count];
        }

        /// <summary><para>This is a method to check whether all responses are taken or not. The GenerateResponse() method is dependent on this check.</para></summary>
        public bool AllResponsesUsed (bool[] ResponsesTaken) // are all responses taken? fixes the problem of that, of instrumental help to the GenerateResponse() method
        {
            for (int i = 0; i < ResponsesTaken.Length; i++)
                if (!ResponsesTaken[i])
                    return false;
            return true;
        }

        /// <summary><para>This is the method used for response generation. Returns a string from the collection based on the randomly assigned integer-based index.</para></summary>
        public string GenerateResponse () // primary method meant to return a string from the response table
        {
            string ResponseToReturn = string.Empty;
            int ResponseIndex = _rnd.Next(0, _responses.Count);
            if (!AllResponsesUsed(_isResponseUsed))
            {
                if (!_isResponseUsed[ResponseIndex])
                {
                    _isResponseUsed[ResponseIndex] = true;
                    return _responses[ResponseIndex]; // returns the randomized string when response isn't taken
                }
                else
                {
                    for (int i = 0; i < _responses.Count; i++) // it would be more intensive to keep bruteforcing with the Random instance, so iterate through the taken array until it sees something not taken
                    {
                        if (!_isResponseUsed[i]) // response hasn't been taken? take it, it's guaranteed since the check of "all responses used" is done before this
                        {
                            _isResponseUsed[i] = true;
                            ResponseToReturn = _responses[i];
                            break;
                        }
                    }
                    return ResponseToReturn; // returns response found from for loop
                }
            }
            else // reset responses taken list and try again
            {
                for (int i = 0; i < _isResponseUsed.Length; i++)
                    _isResponseUsed[i] = false;
                return GenerateResponse(); // back to square one
            }
        }
    }
}
