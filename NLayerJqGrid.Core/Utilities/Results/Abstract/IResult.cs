namespace NLayerJqGrid.Core.Utilities.Results.Abstract
{
	public interface IResult
	{

		public ResultStatus ResultStatus { get; }
		public string Message { get; }
	}
}
