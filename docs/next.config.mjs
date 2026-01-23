import nextra from 'nextra'

const withNextra = nextra({
  theme: 'nextra-theme-docs',
  themeConfig: './theme.config.tsx',
  defaultShowCopyCode: true,
})

export default withNextra({
  output: 'export',
  basePath: '/capnp-dotnet',
  images: {
    unoptimized: true,
  },
  trailingSlash: true,
})
