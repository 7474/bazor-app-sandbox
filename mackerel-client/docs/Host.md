# Koudenpa.Mackerel.Api.Model.Host
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **decimal** | ホストの登録時刻（epoch秒） | 
**Id** | **string** | ホストID | 
**Name** | **string** | ホスト名 | 
**DisplayName** | **string** | optional ホストの管理名 | [optional] 
**CustomIdentifier** | **string** | optional ホストに対するユーザー独自の識別子 | [optional] 
**Meta** | [**Object**](.md) | ホストのメタ情報 | 
**Interfaces** | **List&lt;Object&gt;** | ホストのネットワークインターフェース情報 | 
**Type** | **string** | ホストの種別（\&quot;agent\&quot;, \&quot;container-agent\&quot;, \&quot;cloud\&quot; など） | 
**Status** | **string** | ホストのステータス（\&quot;working\&quot;, \&quot;standby\&quot; など） | 
**Memo** | **string** | ホストに関するメモ。メモは管理画面から編集できます。 | 
**IsRetired** | **bool** | ホストが退役しているかどうか | 
**RetiredAt** | **decimal** | optional ホストの退役時刻（epoch秒） | 
**Roles** | [**Object**](.md) | ホストが所属しているロールの一覧。キーはサービス名、値はそのサービスにおけるロール名の配列です。 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

