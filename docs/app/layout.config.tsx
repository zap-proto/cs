import type { BaseLayoutProps } from 'fumadocs-ui/layouts/shared';

export const baseOptions: BaseLayoutProps = {
  nav: {
    title: "ZAP .NET",
  },
  links: [
    {
      text: 'Documentation',
      url: '/docs',
      active: 'nested-url',
    },
    {
      text: 'GitHub',
      url: 'https://github.com/zap-proto/cs',
    },
    {
      text: 'NuGet',
      url: 'https://www.nuget.org/packages/Zap.Net.Runtime',
    },
  ],
};
