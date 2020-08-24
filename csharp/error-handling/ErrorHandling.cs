using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        return int.TryParse(input, out var intValue) ? intValue : (int?)null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        if (int.TryParse(input, out var intValue))
        {
            result = intValue;
            return true;
        }

        result = 0;
        return false;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        disposableObject.Dispose();
        throw new Exception();
    }
}
