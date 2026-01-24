import Link from 'next/link';

export default function HomePage() {
  return (
    <main className="flex min-h-screen flex-col items-center justify-center p-8 text-center">
      <h1 className="mb-4 text-4xl font-bold">Cap&apos;n Proto for .NET</h1>
      <p className="mb-8 max-w-2xl text-lg text-muted-foreground">
        A high-performance Cap&apos;n Proto implementation for .NET Standard 2.0 and .NET 6+.
        Zero-copy serialization and capability-based RPC.
      </p>
      <Link
        href="/docs"
        className="rounded-lg bg-primary px-6 py-3 font-medium text-primary-foreground hover:bg-primary/90"
      >
        Get Started
      </Link>
    </main>
  );
}
