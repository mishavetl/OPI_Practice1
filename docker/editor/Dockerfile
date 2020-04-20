FROM alpine:latest

# Better terminal support
ENV TERM screen-256color
ENV DEBIAN_FRONTEND noninteractive

# Update and install
RUN apk add --no-cache bash neovim neovim-doc

# Change the workdir, Put it inside root so I can see neovim settings in finder
WORKDIR /code

# # Neovim needs this so that <ctrl-h> can work
# RUN infocmp $TERM | sed 's/kbs=^[hH]/kbs=\\177/' > /tmp/$TERM.ti
# RUN tic /tmp/$TERM.ti

# Command for the image
# CMD ['/bin/bash']
# Install neovim plugins
# RUN nvim -i NONE -c PlugInstall -c quitall > /dev/null 2>&1
