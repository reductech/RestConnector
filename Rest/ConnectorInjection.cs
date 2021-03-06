using System.IO.Abstractions;
using Reductech.Sequence.Core.Connectors;
using Reductech.Sequence.Core.Internal.Errors;

namespace Reductech.Sequence.Connectors.Rest;

/// <summary>
/// For injecting the connector context
/// </summary>
public sealed class ConnectorInjection : IConnectorInjection
{
    /// <summary>
    /// The key for FileSystem injection
    /// </summary>
    public const string FileSystemKey = "Rest.FileSystem";

    /// <inheritdoc />
    public Result<IReadOnlyCollection<(string Name, object Context)>, IErrorBuilder>
        TryGetInjectedContexts()
    {
        IFileSystem fileSystem = new FileSystem();

        IReadOnlyCollection<(string Name, object Context)> list =
            new List<(string Name, object Context)> { (FileSystemKey, fileSystem) };

        return Result.Success<IReadOnlyCollection<(string Name, object Context)>, IErrorBuilder>(
            list
        );
    }
}
