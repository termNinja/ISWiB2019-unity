#! /usr/bin/env bash
# pandoc -t beamer gamedev.iswib2019.md  --pdf-engine=xelatex -V theme:metropolis -o gamedev.iswib2019.pdf
pandoc \
    -t beamer gamedev.iswib2019.md \
    -V theme:metropolis \
    -o gamedev.iswib2019.pdf 