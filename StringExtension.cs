namespace DotCreative.OpenSource.PrimitiveTypesValidations
{
  public static class StringExtension
  {
    /// <summary>
    /// Requires a string is null
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool IsNull(this string val) => val is null ? true : false;

    /// <summary>
    /// Requires a string is not null
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool IsNotNull(this string val) => val is not null ? true : false;
  }
}
