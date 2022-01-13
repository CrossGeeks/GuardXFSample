using Dawn;

namespace GuardXFSample
{
    public static class GuardExtensions
    {
        public static Guard.ArgumentInfo<string> IsAValidEmail(this Guard.ArgumentInfo<string> guard) =>
            guard.NotNull()
                 .NotWhiteSpace()
                 .Matches("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

        public static Guard.ArgumentInfo<string> IsAValidString(this Guard.ArgumentInfo<string> guard) =>
           guard.NotNull()
                .NotWhiteSpace()
                .Modify(s => s.Trim());
    }
}
