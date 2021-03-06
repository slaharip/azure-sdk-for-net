// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.StoreFileSystem.Models;

namespace Microsoft.Azure.Management.DataLake.StoreFileSystem
{
    /// <summary>
    /// Operations for managing the Data Lake Store filesystem
    /// </summary>
    public partial interface IFileSystemOperations
    {
        /// <summary>
        /// Appends to the file specified in the link that was returned from
        /// BeginAppend.
        /// </summary>
        /// <param name='fileAppendRequestLink'>
        /// The link to the file to append to including all required parameters.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> AppendAsync(string fileAppendRequestLink, Stream streamContents, CancellationToken cancellationToken);
        
        /// <summary>
        /// Initiates a file append request, resulting in a return of the data
        /// node location that will service the request.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to append to.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to append to the file in
        /// </param>
        /// <param name='bufferSize'>
        /// The optional buffer size to use when appending data
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response recieved after the BeginOpen, BeginCreate and
        /// BeginAppend requests.
        /// </returns>
        Task<FileCreateOpenAndAppendResponse> BeginAppendAsync(string filePath, string accountName, long? bufferSize, CancellationToken cancellationToken);
        
        /// <summary>
        /// Initiates a file creation request, resulting in a return of the
        /// data node location that will service the request.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to create.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to create the file in
        /// </param>
        /// <param name='parameters'>
        /// The optional parameters to use when creating the file
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response recieved after the BeginOpen, BeginCreate and
        /// BeginAppend requests.
        /// </returns>
        Task<FileCreateOpenAndAppendResponse> BeginCreateAsync(string filePath, string accountName, FileCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Initiates a file open (read) request, resulting in a return of the
        /// data node location that will service the request.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to open.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='parameters'>
        /// The optional parameters to pass to the open operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response recieved after the BeginOpen, BeginCreate and
        /// BeginAppend requests.
        /// </returns>
        Task<FileCreateOpenAndAppendResponse> BeginOpenAsync(string filePath, string accountName, FileOpenParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Checks if the specified access is available at the given path.
        /// </summary>
        /// <param name='path'>
        /// The path to the file or folder to check access for.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='fsAction'>
        /// File system operation read/write/execute in string form, matching
        /// regex pattern '[rwx-]{3}'
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CheckAccessAsync(string path, string accountName, string fsAction, CancellationToken cancellationToken);
        
        /// <summary>
        /// Concatenates the list of files into the target file.
        /// </summary>
        /// <param name='destinationPath'>
        /// The path to the destination file resulting from the concatenation.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='paths'>
        /// A list of comma seperated absolute FileSystem paths without scheme
        /// and authority
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ConcatAsync(string destinationPath, string accountName, string paths, CancellationToken cancellationToken);
        
        /// <summary>
        /// Appends to the file specified. This method supports multiple
        /// concurrent appends to the file. NOTE: that concurrent append and
        /// serial append CANNOT be used interchangeably. Once a file has been
        /// appended to using either one, it can only be appended to using
        /// that type of append.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the data lake account that the file lives in.
        /// </param>
        /// <param name='filePath'>
        /// The path to the file to append to using concurrent append.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ConcurrentAppendAsync(string accountName, string filePath, Stream streamContents, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates the file specified in the link that was returned from
        /// BeginCreate.
        /// </summary>
        /// <param name='fileCreateRequestLink'>
        /// The link to the file to create including all required parameters.
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when creating the file. This parameter
        /// is required, however it can be an empty stream. Just not null.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateAsync(string fileCreateRequestLink, Stream streamContents, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a symbolic link.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory or file to create a symlink of.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='destinationPath'>
        /// The path to create the symlink at
        /// </param>
        /// <param name='createParent'>
        /// If the parent directories do not exist, indicates if they should be
        /// created.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateSymLinkAsync(string sourcePath, string accountName, string destinationPath, bool? createParent, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the requested file or folder, optionally recursively.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file or folder to delete.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='recursive'>
        /// The optional switch indicating if the delete should be recursive
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The result of the request or operation.
        /// </returns>
        Task<FileOperationResultResponse> DeleteAsync(string filePath, string accountName, bool recursive, CancellationToken cancellationToken);
        
        /// <summary>
        /// Directly appends to a file with the specified content, without
        /// requiring a redirect. This API is NOT webhdfs compliant. It should
        /// be used only by tools that do not rely on webhdfs interoperability.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to append to.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to append to the file in
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when appending to the file.
        /// </param>
        /// <param name='bufferSize'>
        /// The optional buffer size to use when appending data
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DirectAppendAsync(string filePath, string accountName, Stream streamContents, long? bufferSize, CancellationToken cancellationToken);
        
        /// <summary>
        /// Directly creates a file with the specified content, without
        /// requiring a redirect. This API is NOT webhdfs compliant. It should
        /// be used only by tools that do not rely on webhdfs interoperability.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to create.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to create the file in
        /// </param>
        /// <param name='streamContents'>
        /// The file contents to include when creating the file. This parameter
        /// is required, however it can be an empty stream. Just not null.
        /// </param>
        /// <param name='parameters'>
        /// The optional parameters to use when creating the file
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DirectCreateAsync(string filePath, string accountName, Stream streamContents, FileCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Directly opens and reads from the specified file, without requiring
        /// a redirect. This API is NOT webhdfs compliant. It should be used
        /// only by tools that do not rely on webhdfs interoperability.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to open.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='parameters'>
        /// The optional parameters to pass to the open operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The data from the file requested.
        /// </returns>
        Task<FileOpenResponse> DirectOpenAsync(string filePath, string accountName, FileOpenParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets ACL entries on a file or folder.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the directory or file to get ACLs on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Store filesystem Acl information.
        /// </returns>
        Task<AclStatusResponse> GetAclStatusAsync(string filePath, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the file content summary object specified by the file path.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to open.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Store filesystem content summary information response.
        /// </returns>
        Task<ContentSummaryResponse> GetContentSummaryAsync(string filePath, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the file status object specified by the file path.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to retrieve status for.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Store filesystem file status information response.
        /// </returns>
        Task<FileStatusResponse> GetFileStatusAsync(string filePath, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the home directory for the specified account.
        /// </summary>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Store filesystem home path response.
        /// </returns>
        Task<HomeDirectoryResponse> GetHomeDirectoryAsync(string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of file status objects specified by the file path.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the file to retrieve status for.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='parameters'>
        /// Query parameters. If null is passed returns all file status items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Data Lake Store filesystem file status list information response.
        /// </returns>
        Task<FileStatusesResponse> ListFileStatusAsync(string filePath, string accountName, DataLakeStoreFileSystemListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name='path'>
        /// The path to the directory to create.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='permission'>
        /// The optional permissions to set on the directories
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The result of the request or operation.
        /// </returns>
        Task<FileOperationResultResponse> MkdirsAsync(string path, string accountName, string permission, CancellationToken cancellationToken);
        
        /// <summary>
        /// Modifies existing ACL entries on a file or folder.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the directory or file to modify ACLs on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='aclSpec'>
        /// The ACL spec included in ACL modification operations in the format
        /// '[default:]user|group|other::r|-w|-x|-'
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ModifyAclEntriesAsync(string filePath, string accountName, string aclSpec, CancellationToken cancellationToken);
        
        /// <summary>
        /// Concatenates the list of files into the target file. This API is
        /// NOT webhdfs compliant, however supports a much larger list of
        /// files in the concatenate list.
        /// </summary>
        /// <param name='destinationPath'>
        /// The path to the destination file resulting from the concatenation.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='streamContents'>
        /// A list of comma seperated absolute FileSystem paths without scheme
        /// and authority. In the format: 'sources=<comma separated list>'
        /// </param>
        /// <param name='deleteSourceDirectory'>
        /// Indicates two things to the system which allow for optimizations
        /// and increased concatenate performance. First, that all the streams
        /// being concatenated are in the same source directory. Second, that
        /// the source directory ONLY has streams in it that are being
        /// concatenated into the destination stream. Note that only the first
        /// requirement is strictly enforced (concatenate will ignore the flag
        /// and only delete the source streams, not the folder). If the first
        /// option is met, ALL data that was not part of the set of streams
        /// being concatenated WILL BE LOST.It is critical to only use this
        /// option if you are certain the two requirements are met.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> MsConcatAsync(string destinationPath, string accountName, Stream streamContents, bool? deleteSourceDirectory, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the data associated with the file handle requested.
        /// </summary>
        /// <param name='fileOpenRequestLink'>
        /// The link to the file to open including all required parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The data from the file requested.
        /// </returns>
        Task<FileOpenResponse> OpenAsync(string fileOpenRequestLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes the existing ACL on a file or folder.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the directory or file to remove ACL on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> RemoveAclAsync(string filePath, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes existing ACL entries on a file or folder.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the directory or file to remove ACLs on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='aclSpec'>
        /// The ACL spec included in ACL removal operations in the format
        /// '[default:]user|group|other'
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> RemoveAclEntriesAsync(string filePath, string accountName, string aclSpec, CancellationToken cancellationToken);
        
        /// <summary>
        /// Removes default ACL entries on a file or folder.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the directory or file to remove default ACLs on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> RemoveDefaultAclAsync(string filePath, string accountName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Rename a directory or file.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory to move/rename.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='destinationPath'>
        /// The path to move/rename the file or folder to
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The result of the request or operation.
        /// </returns>
        Task<FileOperationResultResponse> RenameAsync(string sourcePath, string accountName, string destinationPath, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets ACL entries on a file or folder.
        /// </summary>
        /// <param name='filePath'>
        /// The path to the directory or file to set ACLs on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='aclSpec'>
        /// The ACL spec included in ACL creation operations in the format
        /// '[default:]user|group|other::r|-w|-x|-'
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetAclAsync(string filePath, string accountName, string aclSpec, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets the owner of a file or folder.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory or file to set the owner on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='owner'>
        /// The username who is the owner of a file/directory, if empty remains
        /// unchanged.
        /// </param>
        /// <param name='group'>
        /// The name of a group, if empty remains unchanged.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetOwnerAsync(string sourcePath, string accountName, string owner, string group, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets the permission of the file or folder.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory or file to set permissions on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='permission'>
        /// A string octal representation of the permission (i.e 'rwx')
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetPermissionAsync(string sourcePath, string accountName, string permission, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets the value of the replication factor.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory or file to create a replication of.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='replication'>
        /// The number of replications of a file.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The result of the request or operation.
        /// </returns>
        Task<FileOperationResultResponse> SetReplicationAsync(string sourcePath, string accountName, short? replication, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets the access or modification time on a file or folder.
        /// </summary>
        /// <param name='sourcePath'>
        /// The path to the directory or file to set permissions on.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to use
        /// </param>
        /// <param name='modificationTime'>
        /// The modification time of a file/directory. If -1 remains unchanged
        /// </param>
        /// <param name='accessTime'>
        /// The access time of a file/directory. If -1 remains unchanged
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetTimesAsync(string sourcePath, string accountName, long modificationTime, long accessTime, CancellationToken cancellationToken);
    }
}
