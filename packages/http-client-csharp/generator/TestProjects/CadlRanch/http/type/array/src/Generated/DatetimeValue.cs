// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _Type._Array
{
    public partial class DatetimeValue
    {
        protected DatetimeValue() => throw null;

        public ClientPipeline Pipeline => throw null;

        public virtual ClientResult Get(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetAsync(RequestOptions options) => throw null;

        public virtual ClientResult<IList<DateTimeOffset>> Get() => throw null;

        public virtual Task<ClientResult<IList<DateTimeOffset>>> GetAsync() => throw null;

        public virtual ClientResult Put(BinaryContent content, RequestOptions options) => throw null;

        public virtual Task<ClientResult> PutAsync(BinaryContent content, RequestOptions options) => throw null;

        public virtual ClientResult Put(IList<DateTimeOffset> body) => throw null;

        public virtual Task<ClientResult> PutAsync(IList<DateTimeOffset> body) => throw null;
    }
}