// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Reports.
    /// </summary>
    public static partial class ReportsExtensions
    {
            /// <summary>
            /// Gets a list of reports available within the specified workspace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            public static ODataResponseListReport GetReports(this IReports operations, string collectionName, string workspaceId)
            {
                return operations.GetReportsAsync(collectionName, workspaceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of reports available within the specified workspace
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListReport> GetReportsAsync(this IReports operations, string collectionName, string workspaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportsWithHttpMessagesAsync(collectionName, workspaceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Clones the specified report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            /// <param name='requestParameters'>
            /// Clone report parameters
            /// </param>
            public static Report CloneReport(this IReports operations, string collectionName, string workspaceId, string reportKey, CloneReportRequest requestParameters)
            {
                return operations.CloneReportAsync(collectionName, workspaceId, reportKey, requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Clones the specified report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            /// <param name='requestParameters'>
            /// Clone report parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Report> CloneReportAsync(this IReports operations, string collectionName, string workspaceId, string reportKey, CloneReportRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CloneReportWithHttpMessagesAsync(collectionName, workspaceId, reportKey, requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports the specified report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            public static Stream ExportReport(this IReports operations, string collectionName, string workspaceId, string reportKey)
            {
                return operations.ExportReportAsync(collectionName, workspaceId, reportKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports the specified report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> ExportReportAsync(this IReports operations, string collectionName, string workspaceId, string reportKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ExportReportWithHttpMessagesAsync(collectionName, workspaceId, reportKey, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Deletes the specified report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            public static object DeleteReport(this IReports operations, string collectionName, string workspaceId, string reportKey)
            {
                return operations.DeleteReportAsync(collectionName, workspaceId, reportKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteReportAsync(this IReports operations, string collectionName, string workspaceId, string reportKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteReportWithHttpMessagesAsync(collectionName, workspaceId, reportKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Rebinds the specified report to requested dataset id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            /// <param name='requestParameters'>
            /// Rebind report parameters
            /// </param>
            public static object RebindReport(this IReports operations, string collectionName, string workspaceId, string reportKey, RebindReportRequest requestParameters)
            {
                return operations.RebindReportAsync(collectionName, workspaceId, reportKey, requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rebinds the specified report to requested dataset id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='reportKey'>
            /// The report id
            /// </param>
            /// <param name='requestParameters'>
            /// Rebind report parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RebindReportAsync(this IReports operations, string collectionName, string workspaceId, string reportKey, RebindReportRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RebindReportWithHttpMessagesAsync(collectionName, workspaceId, reportKey, requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
