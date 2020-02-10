using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biblio : MonoBehaviour
{
    // public List<string> V = new List<string>();
    //public List<string> W = new List<string>();
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public static string Bib(string p0)
    {
        var p = ""; var s = 0;
        for (int i = 0; i < p0.Length; i++)
        {
            p = p + p0[i];
            if (p0[i] == ' ') s += 1;
            if (s > 1) break;
        }
       // Debug.Log(p);
        var v = ""; var W = new List<string>();
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pppppppp/5n2/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq - 1 2".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkb1r/pppppppp/5n2/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3 0 2".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkb1r/pppp1ppp/4pn2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq - 0 3".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq - 0 3".Contains(p))
            W.Add(" b7-b6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3 0 2".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/pppp1ppp/4p3/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq - 0 2".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3 0 2".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add(" d7-d6 ");
        if ("rnbqkbnr/pp2pppp/3p4/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq - 0 3".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pp2pppp/3p4/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3 0 3".Contains(p))
            W.Add(" c5:d4 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Bf1-c4 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR b KQkq - 0 2".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR w KQkq - 1 3".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/2N5/PPPP1PPP/R1BQK1NR b KQkq - 1 3".Contains(p))
            W.Add("Nb8-c6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/pppp1ppp/4p3/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq - 0 2".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3 0 2".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/8/PPP2PPP/RNBQKBNR w KQkq d6 0 3".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq - 0 3".Contains(p))
            W.Add("Bf8-b4 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/ppp1pppp/5n2/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq - 1 3".Contains(p))
            W.Add("Bc1-f4 ");
        if ("rnbqkb1r/ppp1pppp/5n2/3p4/3P1B2/5N2/PPP1PPPP/RN1QKB1R b KQkq - 1 3".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq - 1 3".Contains(p))
            W.Add("Bf1-b5 ");
        if ("r1bqkbnr/pppp1ppp/2n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq - 1 3".Contains(p))
            W.Add(" d7-d6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq - 1 3".Contains(p))
            W.Add("Bf1-b5 ");
        if ("r1bqkbnr/pppp1ppp/2n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq - 1 3".Contains(p))
            W.Add(" d7-d6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2".Contains(p))
            W.Add("Bf1-c4 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/2B1P3/8/PPPP1PPP/RNBQK1NR b KQkq - 0 2".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/pp1p1ppp/4p3/2p5/2B1P3/8/PPPP1PPP/RNBQK1NR w KQkq - 0 3".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkbnr/pp1p1ppp/4p3/2p5/2B1P3/2N5/PPPP1PPP/R1BQK1NR b KQkq - 0 3".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pp1p1ppp/2n1p3/2p5/2B1P3/2N5/PPPP1PPP/R1BQK1NR w KQkq - 1 4".Contains(p))
            W.Add("Ng1-e2 ");
        if ("r1bqkbnr/pp1p1ppp/2n1p3/2p5/2B1P3/2N5/PPPPNPPP/R1BQK2R b KQkq - 1 4".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq - 0 2".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq - 1 3".Contains(p))
            W.Add("Bf1-c4 ");
        if ("r1bqkbnr/pp1ppppp/2n5/2p5/2B1P3/2N5/PPPP1PPP/R1BQK1NR b KQkq - 1 3".Contains(p))
            W.Add(" d7-d6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq - 1 3".Contains(p))
            W.Add("Nb1-c3 ");
        if ("r1bqkbnr/pppp1ppp/2n5/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq - 1 3".Contains(p))
            W.Add("Ng8-f6 ");
        if ("r1bqkb1r/pppp1ppp/2n2n2/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq - 2 4".Contains(p))
            W.Add("Bf1-b5 ");
        if ("r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/2N2N2/PPPP1PPP/R1BQK2R b KQkq - 2 4".Contains(p))
            W.Add("Bf8-b4 ");
        if ("r1bqk2r/pppp1ppp/2n2n2/1B2p3/1b2P3/2N2N2/PPPP1PPP/R1BQK2R w KQkq - 3 5".Contains(p))
            W.Add("Ke1-g1 ");
        if ("r1bqk2r/pppp1ppp/2n2n2/1B2p3/1b2P3/2N2N2/PPPP1PPP/R1BQ1RK1 b kq - 3 5".Contains(p))
            W.Add("Ke8-g8 ");
        if ("r1bq1rk1/pppp1ppp/2n2n2/1B2p3/1b2P3/2N2N2/PPPP1PPP/R1BQ1RK1 w - - 4 6".Contains(p))
            W.Add(" d2-d3 ");
        if ("r1bq1rk1/pppp1ppp/2n2n2/1B2p3/1b2P3/2NP1N2/PPP2PPP/R1BQ1RK1 b - - 0 6".Contains(p))
            W.Add(" d7-d6 ");
        if ("r1bq1rk1/ppp2ppp/2np1n2/1B2p3/1b2P3/2NP1N2/PPP2PPP/R1BQ1RK1 w - - 0 7".Contains(p))
            W.Add("Bc1-g5 ");
        if ("r1bq1rk1/ppp2ppp/2np1n2/1B2p1B1/1b2P3/2NP1N2/PPP2PPP/R2Q1RK1 b - - 0 7".Contains(p))
            W.Add("Bb4:c3 ");
        if ("r1bq1rk1/ppp2ppp/2np1n2/1B2p1B1/4P3/2bP1N2/PPP2PPP/R2Q1RK1 w - - 0 8".Contains(p))
            W.Add(" b2:c3 ");
        if ("r1bq1rk1/ppp2ppp/2np1n2/1B2p1B1/4P3/2PP1N2/P1P2PPP/R2Q1RK1 b - - 0 8".Contains(p))
            W.Add(" h7-h6 ");
        if ("r1bq1rk1/ppp2pp1/2np1n1p/1B2p1B1/4P3/2PP1N2/P1P2PPP/R2Q1RK1 w - - 0 9".Contains(p))
            W.Add("Bg5-h4 ");
        if ("r1bq1rk1/ppp2pp1/2np1n1p/1B2p3/4P2B/2PP1N2/P1P2PPP/R2Q1RK1 b - - 0 9".Contains(p))
            W.Add("Bc8-d7 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2".Contains(p))
            W.Add("Bf1-c4 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/2B1P3/8/PPPP1PPP/RNBQK1NR b KQkq - 0 2".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/pp1p1ppp/4p3/2p5/2B1P3/8/PPPP1PPP/RNBQK1NR w KQkq - 0 3".Contains(p))
            W.Add("Qd1-e2 ");
        if ("rnbqkbnr/pp1p1ppp/4p3/2p5/2B1P3/8/PPPPQPPP/RNB1K1NR b KQkq - 0 3".Contains(p))
            W.Add("Nb8-c6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3 0 2".Contains(p))
            W.Add(" d5:c4 ");
        if ("rnbqkbnr/ppp1pppp/8/8/2pP4/8/PP2PPPP/RNBQKBNR w KQkq - 0 3".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/ppp1pppp/8/8/2pPP3/8/PP3PPP/RNBQKBNR b KQkq e3 0 3".Contains(p))
            W.Add(" b7-b5 ");
        if ("rnbqkbnr/p1p1pppp/8/1p6/2pPP3/8/PP3PPP/RNBQKBNR w KQkq b6 0 4".Contains(p))
            W.Add(" a2-a4 ");
        if ("rnbqkbnr/p1p1pppp/8/1p6/P1pPP3/8/1P3PPP/RNBQKBNR b KQkq a3 0 4".Contains(p))
            W.Add("Bc8-b7 ");
        if ("rn1qkbnr/pbp1pppp/8/1p6/P1pPP3/8/1P3PPP/RNBQKBNR w KQkq - 1 5".Contains(p))
            W.Add(" a4:b5 ");
        if ("rn1qkbnr/pbp1pppp/8/1P6/2pPP3/8/1P3PPP/RNBQKBNR b KQkq - 0 5".Contains(p))
            W.Add("Bb7:e4 ");
        if ("rn1qkbnr/p1p1pppp/8/1P6/2pPb3/8/1P3PPP/RNBQKBNR w KQkq - 0 6".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rn1qkbnr/p1p1pppp/8/1P6/2pPb3/2N5/1P3PPP/R1BQKBNR b KQkq - 0 6".Contains(p))
            W.Add("Be4-b7 ");
        if ("rn1qkbnr/pbp1pppp/8/1P6/2pP4/2N5/1P3PPP/R1BQKBNR w KQkq - 1 7".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rn1qkbnr/pbp1pppp/8/1P6/2pP4/2N2N2/1P3PPP/R1BQKB1R b KQkq - 1 7".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rn1qkb1r/pbp1pppp/5n2/1P6/2pP4/2N2N2/1P3PPP/R1BQKB1R w KQkq - 2 8".Contains(p))
            W.Add("Bf1:c4 ");
        if ("rn1qkb1r/pbp1pppp/5n2/1P6/2BP4/2N2N2/1P3PPP/R1BQK2R b KQkq - 0 8".Contains(p))
            W.Add(" e7-e6 ");
        if ("rn1qkb1r/pbp2ppp/4pn2/1P6/2BP4/2N2N2/1P3PPP/R1BQK2R w KQkq - 0 9".Contains(p))
            W.Add("Ke1-g1");
        if ("rn1qkb1r/pbp2ppp/4pn2/1P6/2BP4/2N2N2/1P3PPP/R1BQ1RK1 b kq - 0 9".Contains(p))
            W.Add("Bf8-e7 ");
        if ("rn1qk2r/pbp1bppp/4pn2/1P6/2BP4/2N2N2/1P3PPP/R1BQ1RK1 w kq - 1 10".Contains(p))
            W.Add("Qd1-e2 ");
        if ("rn1qk2r/pbp1bppp/4pn2/1P6/2BP4/2N2N2/1P2QPPP/R1B2RK1 b kq - 1 10".Contains(p))
            W.Add("Ke8-g8");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/pppppppp/8/8/2P5/8/PP1PPPPP/RNBQKBNR b KQkq c3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/2P5/8/PP1PPPPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq - 0 2".Contains(p))
            W.Add("Bf8-b4 ");
        if ("rnbqk1nr/pppp1ppp/8/4p3/1bP5/2N5/PP1PPPPP/R1BQKBNR w KQkq - 1 3".Contains(p))
            W.Add("Nc3-d5 ");
        if ("rnbqk1nr/pppp1ppp/8/3Np3/1bP5/8/PP1PPPPP/R1BQKBNR b KQkq - 1 3".Contains(p))
            W.Add("Bb4-c5 ");
        if ("rnbqk1nr/pppp1ppp/8/2bNp3/2P5/8/PP1PPPPP/R1BQKBNR w KQkq - 2 4".Contains(p))
            W.Add(" e2-e3 ");
        if ("rnbqk1nr/pppp1ppp/8/2bNp3/2P5/4P3/PP1P1PPP/R1BQKBNR b KQkq - 0 4".Contains(p))
            W.Add(" c7-c6 ");
        if ("rnbqk1nr/pp1p1ppp/2p5/2bNp3/2P5/4P3/PP1P1PPP/R1BQKBNR w KQkq - 0 5".Contains(p))
            W.Add("Nd5-c3 ");
        if ("rnbqk1nr/pp1p1ppp/2p5/2b1p3/2P5/2N1P3/PP1P1PPP/R1BQKBNR b KQkq - 0 5".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqk2r/pp1p1ppp/2p2n2/2b1p3/2P5/2N1P3/PP1P1PPP/R1BQKBNR w KQkq - 1 6".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq - 0 3".Contains(p))
            W.Add(" g2-g3 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/3P4/5NP1/PPP1PP1P/RNBQKB1R b KQkq - 0 3".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/ppp2ppp/4pn2/3p4/3P4/5NP1/PPP1PP1P/RNBQKB1R w KQkq - 1 4".Contains(p))
            W.Add("Bf1-g2 ");
        if ("rnbqkb1r/ppp2ppp/4pn2/3p4/3P4/5NP1/PPP1PPBP/RNBQK2R b KQkq - 1 4".Contains(p))
            W.Add("Bf8-e7 ");
        if ("rnbqk2r/ppp1bppp/4pn2/3p4/3P4/5NP1/PPP1PPBP/RNBQK2R w KQkq - 2 5".Contains(p))
            W.Add("Ke1-g1 ");
        if ("rnbqk2r/ppp1bppp/4pn2/3p4/3P4/5NP1/PPP1PPBP/RNBQ1RK1 b kq - 2 5".Contains(p))
            W.Add("Ke8-g8 ");
        if ("rnbq1rk1/ppp1bppp/4pn2/3p4/3P4/5NP1/PPP1PPBP/RNBQ1RK1 w - - 3 6".Contains(p))
            W.Add("Nb1-d2 ");
        if ("rnbq1rk1/ppp1bppp/4pn2/3p4/3P4/5NP1/PPPNPPBP/R1BQ1RK1 b - - 3 6".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbq1rk1/pp2bppp/4pn2/2pp4/3P4/5NP1/PPPNPPBP/R1BQ1RK1 w - c6 0 7".Contains(p))
            W.Add(" d4:c5 ");
        if ("rnbq1rk1/pp2bppp/4pn2/2Pp4/8/5NP1/PPPNPPBP/R1BQ1RK1 b - - 0 7".Contains(p))
            W.Add("Be7:c5 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Bf1-c4 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR b KQkq - 0 2".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR w KQkq - 1 3".Contains(p))
            W.Add(" d2-d3 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/3P4/PPP2PPP/RNBQK1NR b KQkq - 0 3".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkb1r/pppp1ppp/2n2n2/4p3/2B1P3/3P4/PPP2PPP/RNBQK1NR w KQkq - 1 4".Contains(p))
            W.Add("Nb1-c3 ");
        if ("r1bqkb1r/pppp1ppp/2n2n2/4p3/2B1P3/2NP4/PPP2PPP/R1BQK1NR b KQkq - 1 4".Contains(p))
            W.Add("Bf8-b4 ");
        if ("r1bqk2r/pppp1ppp/2n2n2/4p3/1bB1P3/2NP4/PPP2PPP/R1BQK1NR w KQkq - 2 5".Contains(p))
            W.Add("Ng1-e2 ");
        if ("r1bqk2r/pppp1ppp/2n2n2/4p3/1bB1P3/2NP4/PPP1NPPP/R1BQK2R b KQkq - 2 5".Contains(p))
            W.Add(" d7-d5 ");
        if ("r1bqk2r/ppp2ppp/2n2n2/3pp3/1bB1P3/2NP4/PPP1NPPP/R1BQK2R w KQkq d6 0 6".Contains(p))
            W.Add(" e4:d5 ");
        if ("r1bqk2r/ppp2ppp/2n2n2/3Pp3/1bB5/2NP4/PPP1NPPP/R1BQK2R b KQkq - 0 6".Contains(p))
            W.Add("Nf6:d5 ");
        if ("r1bqk2r/ppp2ppp/2n5/3np3/1bB5/2NP4/PPP1NPPP/R1BQK2R w KQkq - 0 7".Contains(p))
            W.Add("Bc1-d2 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add(" c7-c6 ");
        if ("rnbqkbnr/pp2pppp/2p5/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq - 0 3".Contains(p))
            W.Add("Bc1-f4 ");
        if ("rnbqkbnr/pp2pppp/2p5/3p4/3P1B2/5N2/PPP1PPPP/RN1QKB1R b KQkq - 0 3".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pp2pppp/2p2n2/3p4/3P1B2/5N2/PPP1PPPP/RN1QKB1R w KQkq - 1 4".Contains(p))
            W.Add("Nb1-d2 ");
        if ("rnbqkb1r/pp2pppp/2p2n2/3p4/3P1B2/5N2/PPPNPPPP/R2QKB1R b KQkq - 1 4".Contains(p))
            W.Add(" g7-g6 ");
        if ("rnbqkb1r/pp2pp1p/2p2np1/3p4/3P1B2/5N2/PPPNPPPP/R2QKB1R w KQkq - 0 5".Contains(p))
            W.Add(" e2-e3 ");
        if ("rnbqkb1r/pp2pp1p/2p2np1/3p4/3P1B2/4PN2/PPPN1PPP/R2QKB1R b KQkq - 0 5".Contains(p))
            W.Add("Bf8-g7 ");
        if ("rnbqk2r/pp2ppbp/2p2np1/3p4/3P1B2/4PN2/PPPN1PPP/R2QKB1R w KQkq - 1 6".Contains(p))
            W.Add("Bf1-d3 ");
        if ("rnbqk2r/pp2ppbp/2p2np1/3p4/3P1B2/3BPN2/PPPN1PPP/R2QK2R b KQkq - 1 6".Contains(p))
            W.Add("Ke8-g8 ");
        if ("rnbq1rk1/pp2ppbp/2p2np1/3p4/3P1B2/3BPN2/PPPN1PPP/R2QK2R w KQ - 2 7".Contains(p))
            W.Add("Ke1-g1 ");
        if ("rnbq1rk1/pp2ppbp/2p2np1/3p4/3P1B2/3BPN2/PPPN1PPP/R2Q1RK1 b - - 2 7".Contains(p))
            W.Add("Nf6-h5 ");
        if ("rnbq1rk1/pp2ppbp/2p3p1/3p3n/3P1B2/3BPN2/PPPN1PPP/R2Q1RK1 w - - 3 8".Contains(p))
            W.Add("Bf4-g5 ");
        if ("rnbq1rk1/pp2ppbp/2p3p1/3p2Bn/3P4/3BPN2/PPPN1PPP/R2Q1RK1 b - - 3 8".Contains(p))
            W.Add("Qd8-d6 ");
        if ("rnb2rk1/pp2ppbp/2pq2p1/3p2Bn/3P4/3BPN2/PPPN1PPP/R2Q1RK1 w - - 4 9".Contains(p))
            W.Add(" e3-e4 ");
        if ("rnb2rk1/pp2ppbp/2pq2p1/3p2Bn/3PP3/3B1N2/PPPN1PPP/R2Q1RK1 b - - 0 9".Contains(p))
            W.Add(" f7-f6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 0 2".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pp1ppppp/2n5/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq - 1 3".Contains(p))
            W.Add("Nb1-c3 ");
        if ("r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq - 1 3".Contains(p))
            W.Add(" g7-g6 ");
        if ("r1bqkbnr/pp1ppp1p/2n3p1/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq - 0 4".Contains(p))
            W.Add(" d2-d4 ");
        if ("r1bqkbnr/pp1ppp1p/2n3p1/2p5/3PP3/2N2N2/PPP2PPP/R1BQKB1R b KQkq d3 0 4".Contains(p))
            W.Add(" c5:d4 ");
        if ("r1bqkbnr/pp1ppp1p/2n3p1/8/3pP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq - 0 5".Contains(p))
            W.Add("Nf3:d4 ");
        if ("r1bqkbnr/pp1ppp1p/2n3p1/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq - 0 5".Contains(p))
            W.Add("Bf8-g7 ");
        if ("r1bqk1nr/pp1pppbp/2n3p1/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq - 1 6".Contains(p))
            W.Add("Bc1-e3 ");
        if ("r1bqk1nr/pp1pppbp/2n3p1/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq - 1 6".Contains(p))
            W.Add(" d7-d6 ");
        if ("r1bqk1nr/pp2ppbp/2np2p1/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq - 0 7".Contains(p))
            W.Add("Bf1-c4 ");
        if ("r1bqk1nr/pp2ppbp/2np2p1/8/2BNP3/2N1B3/PPP2PPP/R2QK2R b KQkq - 0 7".Contains(p))
            W.Add("Ng8-f6 ");
        if ("r1bqk2r/pp2ppbp/2np1np1/8/2BNP3/2N1B3/PPP2PPP/R2QK2R w KQkq - 1 8".Contains(p))
            W.Add(" h2-h3 ");
        if ("r1bqk2r/pp2ppbp/2np1np1/8/2BNP3/2N1B2P/PPP2PP1/R2QK2R b KQkq - 0 8".Contains(p))
            W.Add("Ke8-g8 ");
        if ("r1bq1rk1/pp2ppbp/2np1np1/8/2BNP3/2N1B2P/PPP2PP1/R2QK2R w KQ - 1 9".Contains(p))
            W.Add("Ke1-g1 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/pppp1ppp/4p3/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq - 0 2".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3 0 2".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/8/PPP2PPP/RNBQKBNR w KQkq d6 0 3".Contains(p))
            W.Add(" e4-e5 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3pP3/3P4/8/PPP2PPP/RNBQKBNR b KQkq - 0 3".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp3ppp/4p3/2ppP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq c6 0 4".Contains(p))
            W.Add(" c2-c3 ");
        if ("rnbqkbnr/pp3ppp/4p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR b KQkq - 0 4".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pp3ppp/2n1p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR w KQkq - 1 5".Contains(p))
            W.Add("Ng1-f3 ");
        if ("r1bqkbnr/pp3ppp/2n1p3/2ppP3/3P4/2P2N2/PP3PPP/RNBQKB1R b KQkq - 1 5".Contains(p))
            W.Add("Bc8-d7 ");
        if ("r2qkbnr/pp1b1ppp/2n1p3/2ppP3/3P4/2P2N2/PP3PPP/RNBQKB1R w KQkq - 2 6".Contains(p))
            W.Add("Bf1-e2 ");
        if ("r2qkbnr/pp1b1ppp/2n1p3/2ppP3/3P4/2P2N2/PP2BPPP/RNBQK2R b KQkq - 2 6".Contains(p))
            W.Add("Ng8-e7 ");
        if ("r2qkb1r/pp1bnppp/2n1p3/2ppP3/3P4/2P2N2/PP2BPPP/RNBQK2R w KQkq - 3 7".Contains(p))
            W.Add("Ke1-g1 ");
        if ("r2qkb1r/pp1bnppp/2n1p3/2ppP3/3P4/2P2N2/PP2BPPP/RNBQ1RK1 b kq - 3 7".Contains(p))
            W.Add("Ne7-g6 ");
        if ("r2qkb1r/pp1b1ppp/2n1p1n1/2ppP3/3P4/2P2N2/PP2BPPP/RNBQ1RK1 w kq - 4 8".Contains(p))
            W.Add("Bc1-e3 ");
        if ("r2qkb1r/pp1b1ppp/2n1p1n1/2ppP3/3P4/2P1BN2/PP2BPPP/RN1Q1RK1 b kq - 4 8".Contains(p))
            W.Add("Bf8-e7 ");
        if ("r2qk2r/pp1bbppp/2n1p1n1/2ppP3/3P4/2P1BN2/PP2BPPP/RN1Q1RK1 w kq - 5 9".Contains(p))
            W.Add(" d4:c5 ");
        if ("r2qk2r/pp1bbppp/2n1p1n1/2PpP3/8/2P1BN2/PP2BPPP/RN1Q1RK1 b kq - 0 9".Contains(p))
            W.Add("Qd8-c7 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3 0 2".Contains(p))
            W.Add(" e5:d4 ");
        if ("rnbqkbnr/pppp1ppp/8/8/3pP3/8/PPP2PPP/RNBQKBNR w KQkq - 0 3".Contains(p))
            W.Add("Qd1:d4 ");
        if ("rnbqkbnr/pppp1ppp/8/8/3QP3/8/PPP2PPP/RNB1KBNR b KQkq - 0 3".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pppp1ppp/2n5/8/3QP3/8/PPP2PPP/RNB1KBNR w KQkq - 1 4".Contains(p))
            W.Add("Qd4-e3 ");
        if ("r1bqkbnr/pppp1ppp/2n5/8/4P3/4Q3/PPP2PPP/RNB1KBNR b KQkq - 1 4".Contains(p))
            W.Add(" g7-g6 ");
        if ("r1bqkbnr/pppp1p1p/2n3p1/8/4P3/4Q3/PPP2PPP/RNB1KBNR w KQkq - 0 5".Contains(p))
            W.Add("Bf1-c4 ");
        if ("r1bqkbnr/pppp1p1p/2n3p1/8/2B1P3/4Q3/PPP2PPP/RNB1K1NR b KQkq - 0 5".Contains(p))
            W.Add("Bf8-g7 ");
        if ("r1bqk1nr/pppp1pbp/2n3p1/8/2B1P3/4Q3/PPP2PPP/RNB1K1NR w KQkq - 1 6".Contains(p))
            W.Add("Ng1-e2 ");
        if ("r1bqk1nr/pppp1pbp/2n3p1/8/2B1P3/4Q3/PPP1NPPP/RNB1K2R b KQkq - 1 6".Contains(p))
            W.Add("Ng8-f6 ");
        if ("r1bqk2r/pppp1pbp/2n2np1/8/2B1P3/4Q3/PPP1NPPP/RNB1K2R w KQkq - 2 7".Contains(p))
            W.Add("Ke1-g1 ");
        if ("r1bqk2r/pppp1pbp/2n2np1/8/2B1P3/4Q3/PPP1NPPP/RNB2RK1 b kq - 2 7".Contains(p))
            W.Add("Ke8-g8 ");
        if ("r1bq1rk1/pppp1pbp/2n2np1/8/2B1P3/4Q3/PPP1NPPP/RNB2RK1 w - - 3 8".Contains(p))
            W.Add("Nb1-c3 ");
        if ("r1bq1rk1/pppp1pbp/2n2np1/8/2B1P3/2N1Q3/PPP1NPPP/R1B2RK1 b - - 3 8".Contains(p))
            W.Add(" d7-d6 ");
        if ("r1bq1rk1/ppp2pbp/2np1np1/8/2B1P3/2N1Q3/PPP1NPPP/R1B2RK1 w - - 0 9".Contains(p))
            W.Add("Qe3-g3 ");
        if ("r1bq1rk1/ppp2pbp/2np1np1/8/2B1P3/2N3Q1/PPP1NPPP/R1B2RK1 b - - 0 9".Contains(p))
            W.Add("Qd8-e8 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3 0 2".Contains(p))
            W.Add(" d5:c4 ");
        if ("rnbqkbnr/ppp1pppp/8/8/2pP4/8/PP2PPPP/RNBQKBNR w KQkq - 0 3".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/ppp1pppp/8/8/2pP4/5N2/PP2PPPP/RNBQKB1R b KQkq - 0 3".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/ppp2ppp/4p3/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq - 0 4".Contains(p))
            W.Add(" e2-e3 ");
        if ("rnbqkbnr/ppp2ppp/4p3/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq - 0 4".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/ppp2ppp/4pn2/8/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq - 1 5".Contains(p))
            W.Add("Bf1:c4 ");
        if ("rnbqkb1r/ppp2ppp/4pn2/8/2BP4/4PN2/PP3PPP/RNBQK2R b KQkq - 0 5".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkb1r/pp3ppp/4pn2/2p5/2BP4/4PN2/PP3PPP/RNBQK2R w KQkq c6 0 6".Contains(p))
            W.Add("Ke1-g1 ");
        if ("rnbqkb1r/pp3ppp/4pn2/2p5/2BP4/4PN2/PP3PPP/RNBQ1RK1 b kq - 0 6".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkb1r/pp3ppp/2n1pn2/2p5/2BP4/4PN2/PP3PPP/RNBQ1RK1 w kq - 1 7".Contains(p))
            W.Add("Nb1-c3 ");
        if ("r1bqkb1r/pp3ppp/2n1pn2/2p5/2BP4/2N1PN2/PP3PPP/R1BQ1RK1 b kq - 1 7".Contains(p))
            W.Add("Bf8-e7 ");
        if ("r1bqk2r/pp2bppp/2n1pn2/2p5/2BP4/2N1PN2/PP3PPP/R1BQ1RK1 w kq - 2 8".Contains(p))
            W.Add("Qd1-e2 ");
        if ("r1bqk2r/pp2bppp/2n1pn2/2p5/2BP4/2N1PN2/PP2QPPP/R1B2RK1 b kq - 2 8".Contains(p))
            W.Add(" c5:d4 ");
        if ("r1bqk2r/pp2bppp/2n1pn2/8/2Bp4/2N1PN2/PP2QPPP/R1B2RK1 w kq - 0 9".Contains(p))
            W.Add("Nf3:d4 ");
        if ("r1bqk2r/pp2bppp/2n1pn2/8/2BN4/2N1P3/PP2QPPP/R1B2RK1 b kq - 0 9".Contains(p))
            W.Add("Bc8-d7 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3 0 2".Contains(p))
            W.Add(" c7-c6 ");
        if ("rnbqkbnr/pp2pppp/2p5/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq - 0 3".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/pp2pppp/2p5/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq - 0 3".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq - 1 4".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq - 1 4".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq - 0 5".Contains(p))
            W.Add(" e2-e3 ");
        if ("rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq - 0 5".Contains(p))
            W.Add("Nb8-d7 ");
        if ("r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2N1PN2/PP3PPP/R1BQKB1R w KQkq - 1 6".Contains(p))
            W.Add("Bf1-d3 ");
        if ("r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2NBPN2/PP3PPP/R1BQK2R b KQkq - 1 6".Contains(p))
            W.Add(" d5:c4 ");
        if ("r1bqkb1r/pp1n1ppp/2p1pn2/8/2pP4/2NBPN2/PP3PPP/R1BQK2R w KQkq - 0 7".Contains(p))
            W.Add("Bd3:c4 ");
        if ("r1bqkb1r/pp1n1ppp/2p1pn2/8/2BP4/2N1PN2/PP3PPP/R1BQK2R b KQkq - 0 7".Contains(p))
            W.Add(" b7-b5 ");
        if ("r1bqkb1r/p2n1ppp/2p1pn2/1p6/2BP4/2N1PN2/PP3PPP/R1BQK2R w KQkq b6 0 8".Contains(p))
            W.Add("Bc4-d3 ");
        if ("r1bqkb1r/p2n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R b KQkq - 0 8".Contains(p))
            W.Add("Bc8-b7 ");
        if ("r2qkb1r/pb1n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R w KQkq - 1 9".Contains(p))
            W.Add("Ke1-g1 ");
        if ("r2qkb1r/pb1n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQ1RK1 b kq - 1 9".Contains(p))
            W.Add("Bf8-e7 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" d2-d4 ");
        if ("rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3 0 1".Contains(p))
            W.Add(" d7-d5 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6 0 2".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3 0 2".Contains(p))
            W.Add(" e7-e6 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq - 0 3".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq - 0 3".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq - 1 4".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq - 1 4".Contains(p))
            W.Add("Bf8-e7 ");
        if ("rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq - 2 5".Contains(p))
            W.Add("Bc1-g5 ");
        if ("rnbqk2r/ppp1bppp/4pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq - 2 5".Contains(p))
            W.Add("Ke8-g8 ");
        if ("rnbq1rk1/ppp1bppp/4pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQ - 3 6".Contains(p))
            W.Add(" e2-e3 ");
        if ("rnbq1rk1/ppp1bppp/4pn2/3p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R b KQ - 0 6".Contains(p))
            W.Add("Nb8-d7 ");
        if ("r1bq1rk1/pppnbppp/4pn2/3p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ - 1 7".Contains(p))
            W.Add("Bf1-d3 ");
        if ("r1bq1rk1/pppnbppp/4pn2/3p2B1/2PP4/2NBPN2/PP3PPP/R2QK2R b KQ - 1 7".Contains(p))
            W.Add(" d5:c4 ");
        if ("r1bq1rk1/pppnbppp/4pn2/6B1/2pP4/2NBPN2/PP3PPP/R2QK2R w KQ - 0 8".Contains(p))
            W.Add("Bd3:c4 ");
        if ("r1bq1rk1/pppnbppp/4pn2/6B1/2BP4/2N1PN2/PP3PPP/R2QK2R b KQ - 0 8".Contains(p))
            W.Add(" a7-a6 ");
        if ("r1bq1rk1/1ppnbppp/p3pn2/6B1/2BP4/2N1PN2/PP3PPP/R2QK2R w KQ - 0 9".Contains(p))
            W.Add("Ke1-g1 ");
        if ("r1bq1rk1/1ppnbppp/p3pn2/6B1/2BP4/2N1PN2/PP3PPP/R2Q1RK1 b - - 0 9".Contains(p))
            W.Add(" b7-b5 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" c7-c5 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkbnr/pp1ppppp/8/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq - 0 2".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq - 1 3".Contains(p))
            W.Add("Ng1-e2 ");
        if ("r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPPNPPP/R1BQKB1R b KQkq - 1 3".Contains(p))
            W.Add(" d7-d6 ");
        if ("r1bqkbnr/pp2pppp/2np4/2p5/4P3/2N5/PPPPNPPP/R1BQKB1R w KQkq - 0 4".Contains(p))
            W.Add(" d2-d4 ");
        if ("r1bqkbnr/pp2pppp/2np4/2p5/3PP3/2N5/PPP1NPPP/R1BQKB1R b KQkq d3 0 4".Contains(p))
            W.Add(" c5:d4 ");
        if ("r1bqkbnr/pp2pppp/2np4/8/3pP3/2N5/PPP1NPPP/R1BQKB1R w KQkq - 0 5".Contains(p))
            W.Add("Ne2:d4 ");
        if ("r1bqkbnr/pp2pppp/2np4/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq - 0 5".Contains(p))
            W.Add("Ng8-f6 ");
        if ("r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq - 1 6".Contains(p))
            W.Add("Bf1-c4 ");
        if ("r1bqkb1r/pp2pppp/2np1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R b KQkq - 1 6".Contains(p))
            W.Add(" e7-e6 ");
        if ("r1bqkb1r/pp3ppp/2nppn2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq - 0 7".Contains(p))
            W.Add("Ke1-g1 ");
        if ("r1bqkb1r/pp3ppp/2nppn2/8/2BNP3/2N5/PPP2PPP/R1BQ1RK1 b kq - 0 7".Contains(p))
            W.Add("Bf8-e7 ");
        if ("r1bqk2r/pp2bppp/2nppn2/8/2BNP3/2N5/PPP2PPP/R1BQ1RK1 w kq - 1 8".Contains(p))
            W.Add("Bc1-e3 ");
        if ("r1bqk2r/pp2bppp/2nppn2/8/2BNP3/2N1B3/PPP2PPP/R2Q1RK1 b kq - 1 8".Contains(p))
            W.Add("Ke8-g8 ");
        if ("r1bq1rk1/pp2bppp/2nppn2/8/2BNP3/2N1B3/PPP2PPP/R2Q1RK1 w - - 2 9".Contains(p))
            W.Add("Bc4-b3 ");
        if ("r1bq1rk1/pp2bppp/2nppn2/8/3NP3/1BN1B3/PPP2PPP/R2Q1RK1 b - - 2 9".Contains(p))
            W.Add("Bc8-d7 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" c2-c4 ");
        if ("rnbqkbnr/pppppppp/8/8/2P5/8/PP1PPPPP/RNBQKBNR b KQkq c3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/2P5/8/PP1PPPPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add(" e2-e3 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/2P5/4P3/PP1P1PPP/RNBQKBNR b KQkq - 0 2".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2P5/4P3/PP1P1PPP/RNBQKBNR w KQkq - 1 3".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N1P3/PP1P1PPP/R1BQKBNR b KQkq - 1 3".Contains(p))
            W.Add("Nb8-c6 ");
        if ("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1".Contains(p))
            W.Add(" e2-e4 ");
        if ("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1".Contains(p))
            W.Add(" e7-e5 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2".Contains(p))
            W.Add("Nb1-c3 ");
        if ("rnbqkbnr/pppp1ppp/8/4p3/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq - 0 2".Contains(p))
            W.Add("Ng8-f6 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq - 1 3".Contains(p))
            W.Add("Bf1-c4 ");
        if ("rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/2N5/PPPP1PPP/R1BQK1NR b KQkq - 1 3".Contains(p))
            W.Add("Bf8-c5 ");
        if ("rnbqk2r/pppp1ppp/5n2/2b1p3/2B1P3/2N5/PPPP1PPP/R1BQK1NR w KQkq - 2 4".Contains(p))
            W.Add("Ng1-f3 ");
        if ("rnbqk2r/pppp1ppp/5n2/2b1p3/2B1P3/2N2N2/PPPP1PPP/R1BQK2R b KQkq - 2 4".Contains(p))
            W.Add("Nb8-c6 ");
        if ("r1bqk2r/pppp1ppp/2n2n2/2b1p3/2B1P3/2N2N2/PPPP1PPP/R1BQK2R w KQkq - 3 5".Contains(p))
            W.Add(" d2-d3 ");
        if ("r1bqk2r/pppp1ppp/2n2n2/2b1p3/2B1P3/2NP1N2/PPP2PPP/R1BQK2R b KQkq - 0 5".Contains(p))
            W.Add(" d7-d6 ");
        if ("r1bqk2r/ppp2ppp/2np1n2/2b1p3/2B1P3/2NP1N2/PPP2PPP/R1BQK2R w KQkq - 0 6".Contains(p))
            W.Add("Bc1-g5 ");
        if ("r1bqk2r/ppp2ppp/2np1n2/2b1p1B1/2B1P3/2NP1N2/PPP2PPP/R2QK2R b KQkq - 0 6".Contains(p))
            W.Add(" h7-h6 ");
        if ("r1bqk2r/ppp2pp1/2np1n1p/2b1p1B1/2B1P3/2NP1N2/PPP2PPP/R2QK2R w KQkq - 0 7".Contains(p))
            W.Add("Bg5-e3 ");
        if ("r1bqk2r/ppp2pp1/2np1n1p/2b1p3/2B1P3/2NPBN2/PPP2PPP/R2QK2R b KQkq - 0 7".Contains(p))
            W.Add("Bc5:e3 ");
        if ("r1bqk2r/ppp2pp1/2np1n1p/4p3/2B1P3/2NPbN2/PPP2PPP/R2QK2R w KQkq - 0 8".Contains(p))
            W.Add(" f2:e3 ");
        if ("r1bqk2r/ppp2pp1/2np1n1p/4p3/2B1P3/2NPPN2/PPP3PP/R2QK2R b KQkq - 0 8".Contains(p))
            W.Add("Bc8-e6 ");
        if ("r2qk2r/ppp2pp1/2npbn1p/4p3/2B1P3/2NPPN2/PPP3PP/R2QK2R w KQkq - 1 9".Contains(p))
            W.Add("Bc4-b5 ");
        if ("r2qk2r/ppp2pp1/2npbn1p/1B2p3/4P3/2NPPN2/PPP3PP/R2QK2R b KQkq - 1 9".Contains(p))
            W.Add("Ke8-g8 ");






        ///  Debug.Log(W.Count + " ход0 " + v);
        ///  for (int i = 0; i < W.Count; i++) Debug.Log(i+"."+W[i] + "");


        if (W.Count > 1)
        {

            var R = Random.Range(0, W.Count); if (R >= W.Count) R = W.Count - 1;
            v = W[R];
        }
        if (W.Count ==1) v = W[0];

        return v;
    }
}
   
