// 代码分析使用此文件来维护应用到此项目的 SuppressMessage 
// 特性。
// 项目级禁止显示或者没有目标，或者已给定 
// 一个特定目标且其范围为命名空间、类型和成员等。
//
// 若要向此文件中添加禁止显示，请右击 
// 代码分析结果中的消息，指向“禁止显示消息”，然后单击 
//“在禁止显示文件中”。
// 无需手动向此文件添加禁止显示。

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.FNV1_32.#hash")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.FNV1a_32.#hash")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemCache.#Servers")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemCache.#Initialize(M2SA.AppGenome.Configuration.IConfigNode)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#checkKey(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#checkKey(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#hash(System.UInt32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#readValue(M2SA.AppGenome.Cache.MemCached.PooledSocket,System.Object&,System.String&,System.UInt64&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#Stats()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#Status()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy+CasResult")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "stream", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.PooledSocket.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "socket", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.PooledSocket.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "M2SA.AppGenome.Cache.MemCached.Serializer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.ServerNode.#Slaves")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.ServerPool.#ConnectTimeout")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.ServerPool.#ServerNodes")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.SocketPool.#IsEndPointDead")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.ServerPool.#ExecuteAll(M2SA.AppGenome.Cache.MemCached.UseSocket)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:不要多次释放对象", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.ServerPool.#Execute`1(M2SA.AppGenome.Cache.MemCached.SocketPool,!!0,M2SA.AppGenome.Cache.MemCached.UseSocket`1<!!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.ServerPool.#Execute`1(M2SA.AppGenome.Cache.MemCached.SocketPool,!!0,M2SA.AppGenome.Cache.MemCached.UseSocket`1<!!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:不要多次释放对象", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.Serializer.#decompress(System.Byte[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#Gets(System.String[],System.UInt64[]&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "2#", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#Gets(System.String,System.UInt32,System.UInt64&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "2#", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#Gets(System.String[],System.UInt32[],System.UInt64[]&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.MemcachedProxy.#Gets(System.String,System.UInt64&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:验证公共方法的参数", MessageId = "0", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.FNV1a_32.#HashCore(System.Byte[],System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:验证公共方法的参数", MessageId = "0", Scope = "member", Target = "M2SA.AppGenome.Cache.MemCached.FNV1_32.#HashCore(System.Byte[],System.Int32,System.Int32)")]
