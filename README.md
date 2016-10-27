# Source Code Proxy
#### Version 0.1.0

## Background

The Source Code Proxy service can be used in conjunction with GitLink and Atlassian Stash/Bitbucket Server to authenticate and rewrite requests from Visual Studio,
when it tries to dynamically fetch the correct file versions.

### How it works

The proxy service translates relative URLs on the following format:
```
/{projectKey}/{repo}/{untilHash}/{filePath}
```

into a Stash-compatible URL:

```
/projects/{projectKey}/repos/{repo}/browse/{filePath}?at={untilHash}&raw
```

* `projectKey` Stash project key.
* `repo` Stash repository.
* `untilHash` The commit hash to use for lookup.
* `filePath` The file path under in the Stash repository to retrieve.

It retrieves the source file from Stash and passes it verbatim through to the client (typically Visual Studio in a debug session).

## Installation

### Web

Install the web application under IIS and change the following settings in IIS:

* `sourceCodeProxy:stashUser` The user to authenticate as against Stash.
* `sourceCodeProxy:stashPassword` The password to authenticate with against Stash.
* `sourceCodeProxy:stashBaseUrl` The base URL of the Stash service.
* 
#### Security

Depdending on your need for confidentiality, the IIS, or an OWIN middleware should be used to secure the service.
E.g. enable Windows authentication (NTLM/Kerberos) in IIS and disable Anonymous authentication. It is also possible
to authorize certain users or groups with the .NET Authorization mechanisms available.

### Tray application

Build it yourself, or download the `SourceCodeProxy.Tray-*-dist.zip` and unpack to a suitable location. Start SourceCodeProxy.Tray and configure it by opening the configuration dialog by double-clicking the tray icon (or right click + _Open..._)
Note that you have to leave the text boxes in order to persist the changes to the configuration file.

Press the _Start_ button to fire up the proxy service. It can be stopped again with the same button (now labeled _Stop_).

#### _hosts_ file tricks

Edit the `c:\windows\system32\drivers\etc\hosts` file (as Administrator) and add the following entry:

```
127.0.0.1   source.code.proxy
```

Now you can configure the Proxy Address to `http://source.code.proxy`.

## About

Developed and maintained by Lars Wilhelmsen <<lars@spam.nospam.spam.spam.sral.org>>

## Credits

Style sheet used on the Welcome page is [https://milligram.github.io/](https://milligram.github.io/)

### License

Apache Public License 2.0

For details, see the [LICENSE](LICENSE) file in the source code tree.