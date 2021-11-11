<Query Kind="Program" />

void Main()
{
	euclids_alorithm(119, 544).Dump();
	euclids_alorithm(2166, 6099).Dump();
}

// Define other methods and classes here

static int euclids_alorithm(int m, int n) {
	Debug.Assert((m + n) > 1);
// F0
	if (m < n) swap(ref m, ref n);
F1:
	m = m % n;
// F2:
	if (0 == m) return n;
// F3:
	n = n % m;
// F4:
	if (0 == n) return m;
	goto F1;
}

static void swap(ref int m, ref int n) { n = Interlocked.Exchange(ref m, n); }