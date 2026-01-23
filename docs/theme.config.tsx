import { DocsThemeConfig } from 'nextra-theme-docs'

const config: DocsThemeConfig = {
  logo: <span style={{ fontWeight: 700 }}>Cap'n Proto for .NET</span>,
  project: {
    link: 'https://github.com/zap-protocol/capnp-dotnet',
  },
  docsRepositoryBase: 'https://github.com/zap-protocol/capnp-dotnet/tree/main/docs',
  footer: {
    text: 'Cap\'n Proto for .NET Documentation',
  },
  head: (
    <>
      <meta name="viewport" content="width=device-width, initial-scale=1.0" />
      <meta name="description" content="Cap'n Proto serialization and RPC for .NET" />
    </>
  ),
  useNextSeoProps() {
    return {
      titleTemplate: '%s - Cap\'n Proto .NET'
    }
  },
  sidebar: {
    defaultMenuCollapseLevel: 1,
    toggleButton: true,
  },
  toc: {
    backToTop: true,
  },
  navigation: {
    prev: true,
    next: true,
  },
}

export default config
