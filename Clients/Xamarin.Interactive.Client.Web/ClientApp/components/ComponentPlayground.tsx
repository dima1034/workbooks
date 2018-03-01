import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { AbortEvaluationButton } from './AbortEvaluationButton';

export class ComponentPlayground extends React.Component<RouteComponentProps<{}>> {
    public render() {
        return (
            <article>
                <h1>Component Playground for Design</h1>
                <h2>Abort Evaluation Button</h2>
                <p>
                    This button acts as a status indicator that a code cell is evaluating; when hovering
                    or otherwise interacting with it however, it will indicate that it may be used to
                    abort the evaluation.
                </p>
                <p>
                    <AbortEvaluationButton />
                </p>
            </article>
        )
    }
}