<Query Kind="Program" />

void Main()
{
	euclids_alorithm(119, 544).Dump();
	euclids_alorithm(2166, 6099).Dump();
}

// Define other methods and classes here

static int euclids_alorithm(int m, int n) {
	Debug.Assert((m + n) > 1);
// E0
	if (m < n) swap(ref m, ref n);
E1:
	int r = m % n;
// E2:		
	if (0 == r) return n;
// E3:
	m = n; n = r;
	goto E1;
}

static void swap(ref int m, ref int n) { n = Interlocked.Exchange(ref m, n); }