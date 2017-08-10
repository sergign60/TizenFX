/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace System
{
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
            new global::System.ApplicationException();
        }

        public ApplicationException(string message)
        {
            new global::System.ApplicationException(message);
        }

        public ApplicationException(string message, Exception innerException)
        {
            new global::System.ApplicationException(message, innerException);
        }
    }

    public class SystemException : Exception
    {
        public SystemException()
        {
            new global::System.SystemException();
        }

        public SystemException(string message)
        {
            new global::System.SystemException(message);
        }

        public SystemException(string message, Exception innerException)
        {
            new global::System.SystemException(message, innerException);
        }
    }
}