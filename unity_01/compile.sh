#! /usr/bin/env bash
#pandoc -t beamer unity01.md  --pdf-engine=xelatex -V theme:metropolis -o unity01.pdf
pandoc -t beamer unity01.md  -V theme:metropolis -o unity01.pdf
