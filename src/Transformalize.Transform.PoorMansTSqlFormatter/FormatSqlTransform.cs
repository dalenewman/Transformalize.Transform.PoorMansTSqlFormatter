using System.Collections.Generic;
using PoorMansTSqlFormatterLib;
using Transformalize.Configuration;
using Transformalize.Contracts;

namespace Transformalize.Transforms.PoorMansTSqlFormatter {
    public class FormatSqlTransform : StringTransform {
        private readonly Field _input;
        private readonly SqlFormattingManager _formattingManager;

        public FormatSqlTransform(IContext context = null) : base(context, "string") {
            if (IsMissingContext()) {
                return;
            }
            _input = SingleInput();
            _formattingManager = new SqlFormattingManager();
        }

        public override IRow Operate(IRow row) {
            var unformatted = GetString(row, _input);
            row[Context.Field] = _formattingManager.Format(unformatted);
            Increment();
            return row;
        }

        public override IEnumerable<OperationSignature> GetSignatures() {
            return new[] { new OperationSignature("formatsql") };
        }
    }
}
